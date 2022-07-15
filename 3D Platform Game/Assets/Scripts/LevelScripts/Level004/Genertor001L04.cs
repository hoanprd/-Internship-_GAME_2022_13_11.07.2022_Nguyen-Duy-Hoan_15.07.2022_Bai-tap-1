using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Genertor001L04 : MonoBehaviour
{
    [SerializeField] private Renderer mate;
    public Transform target1;
    public Transform target2;
    public GameObject Message;
    public AudioSource GS;
    int state = 0;
    bool IsActive = false;

    // Start is called before the first frame update
    void Start()
    {
        mate.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive && Input.GetKeyUp(KeyCode.F))
        {
            GS.Play();
            state++;
            if (state % 2 == 0)
            {
                target1.position = new Vector3(target1.position.x, -0.5f, target1.position.z);
                target2.position = new Vector3(target2.position.x, 5.5f, target2.position.z);
                mate.material.color = Color.white;
            }
            else if (state % 2 != 0)
            {
                target1.position = new Vector3(target1.position.x, 5.5f, target1.position.z);
                target2.position = new Vector3(target2.position.x, -0.5f, target2.position.z);
                mate.material.color = Color.blue;
            }
        }
    }
    private void OnCollisionEnter()
    {
        IsActive = true;
        Message.SetActive(true);
        Message.GetComponent<Text>().text = "Press F to start the elevator";
    }
    private void OnCollisionExit(Collision collision)
    {
        IsActive = false;
        Message.SetActive(false);
    }
}
