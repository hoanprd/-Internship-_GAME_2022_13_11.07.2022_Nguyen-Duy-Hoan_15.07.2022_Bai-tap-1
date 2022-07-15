//
// Mecanimのアニメーションデータが、原点で移動しない場合の Rigidbody付きコントローラ
// サンプル
// 2014/03/13 N.Kobyasahi
//
using UnityEngine;
using System.Collections;

namespace UnityChan
{
	// 必要なコンポーネントの列記
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]

	public class UnityChanControlScriptWithRgidBody1 : MonoBehaviour
	{

		public float animSpeed = 1.5f;              // アニメーション再生速度設定
		public float lookSmoother = 3.0f;           // a smoothing setting for camera motion
		public bool useCurves = true;               // Mecanimでカーブ調整を使うか設定する
													// このスイッチが入っていないとカーブは使われない
		public float useCurvesHeight = 0.5f;        // カーブ補正の有効高さ（地面をすり抜けやすい時には大きくする）

		// 以下キャラクターコントローラ用パラメタ
		// 前進速度
		public float forwardSpeed = 7.0f;
		// 後退速度
		public float backwardSpeed = 2.0f;
		// 旋回速度
		public float rotateSpeed = 2.0f;
		// ジャンプ威力
		public float jumpPower = 3.0f;
		// キャラクターコントローラ（カプセルコライダ）の参照
		private CapsuleCollider col;
		private Rigidbody rb;
		// キャラクターコントローラ（カプセルコライダ）の移動量
		private Vector3 velocity;
		// CapsuleColliderで設定されているコライダのHeiht、Centerの初期値を収める変数
		private float orgColHight;
		private Vector3 orgVectColCenter;
		private Animator anim;                          // キャラにアタッチされるアニメーターへの参照
		private AnimatorStateInfo currentBaseState;         // base layerで使われる、アニメーターの現在の状態の参照

		private GameObject cameraObject;    // メインカメラへの参照

		// アニメーター各ステートへの参照
		static int idleState = Animator.StringToHash("Base Layer.Idle");
		static int locoState = Animator.StringToHash("Base Layer.Locomotion");
		static int jumpState = Animator.StringToHash("Base Layer.Jump");
		static int restState = Animator.StringToHash("Base Layer.Rest");
		public float speed = 5f;
		public bool isground = true;
		// 初期化
		void Start()
		{
			// Animatorコンポーネントを取得する
			//anim = GetComponent<Animator>();
			// CapsuleColliderコンポーネントを取得する（カプセル型コリジョン）
			//col = GetComponent<CapsuleCollider>();
			rb = GetComponent<Rigidbody>();
			//メインカメラを取得する
			cameraObject = GameObject.FindWithTag("MainCamera");
		}

		// 以下、メイン処理.リジッドボディと絡めるので、FixedUpdate内で処理を行う.
		void FixedUpdate()
		{
			float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;             // 入力デバイスの水平軸をhで定義
			float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;               // 入力デ						// Animatorのモーション再生速度に animSpeedを設定する

			if (Input.GetButtonDown("Jump") && isground == true)
			{
				rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
				isground = false;
				//anim.SetBool("Jump", true);
			}
			//transform.Rotate(0, h * rotateSpeed, 0);

			transform.Translate(h, 0, v);
		}
        private void OnCollisionEnter()
        {
			isground = true;
		}
    }
}