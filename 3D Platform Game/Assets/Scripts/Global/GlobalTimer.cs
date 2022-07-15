using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public GameObject Message;
    public GameObject FadeOut;
    public bool isTakingTime = false;
    public int theSeconds = 150;
    public static int extendScore;

    // Update is called once per frame
    void Update()
    {
        extendScore = theSeconds;
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }
        if(theSeconds <= 0)
        {
            StartCoroutine(TimeOut());
        }
    }
    IEnumerator SubtractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        timeDisplay02.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
    IEnumerator TimeOut()
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = "Time Out";
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}
