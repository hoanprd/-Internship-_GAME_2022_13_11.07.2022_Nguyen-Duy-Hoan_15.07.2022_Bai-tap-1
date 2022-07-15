using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("TotalScoreCalc", 0);
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
