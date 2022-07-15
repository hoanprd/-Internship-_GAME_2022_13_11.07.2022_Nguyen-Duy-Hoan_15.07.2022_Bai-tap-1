using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFallBlockL05 : MonoBehaviour
{
    Genertor003L05 G35;
    public Transform FallBlock;
    bool IsFalling = false;
    float FallSpeed = 0;

    private void Start()
    {
        G35 = FindObjectOfType<Genertor003L05>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsFalling && G35.Fall == true)
        {
            FallSpeed += Time.deltaTime/100;
            FallBlock.position = new Vector3(FallBlock.position.x, FallBlock.position.y - FallSpeed, FallBlock.position.z);
            Destroy(gameObject, 5);
        }
    }
    void OnTriggerEnter()
    {
        StartCoroutine(WaitToFall());
    }
    IEnumerator WaitToFall()
    {
        yield return new WaitForSeconds(0.5f);
        IsFalling = true;
    }
}
