using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRed : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 500;
        collectSound.Play();
        Destroy(gameObject);
    }
}
