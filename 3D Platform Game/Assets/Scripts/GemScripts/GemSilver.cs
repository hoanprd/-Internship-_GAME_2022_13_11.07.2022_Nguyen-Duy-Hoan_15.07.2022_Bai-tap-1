using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 100;
        collectSound.Play();
        Destroy(gameObject);
    }
}
