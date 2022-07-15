using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFallBlock : MonoBehaviour
{
    public Transform FallBlock;
    bool IsFalling = false;
    float FallSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        if(IsFalling)
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
