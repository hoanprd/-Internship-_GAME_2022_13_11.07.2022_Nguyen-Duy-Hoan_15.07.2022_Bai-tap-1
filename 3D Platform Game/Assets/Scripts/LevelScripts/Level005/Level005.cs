using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level005 : MonoBehaviour
{
    public GameObject fadeIn;

    // Start is called before the first frame update
    void Start()
    {
        RedirectToLevel.redirectToLevel = 7;
        RedirectToLevel.nextLevel = 8;
        StartCoroutine(FadeInOff());
    }
    
    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
