using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 200;
        collectSound.Play();
        Destroy(gameObject);
    }
}
