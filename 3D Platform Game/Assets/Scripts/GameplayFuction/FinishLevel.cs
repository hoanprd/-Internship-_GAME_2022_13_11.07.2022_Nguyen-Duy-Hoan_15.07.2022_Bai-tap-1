using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject levelBlocker;
    public GameObject fadeOut;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;
        timeCalc = GlobalTimer.extendScore * 10;
        timeLeft.GetComponent<Text>().text = "Time left: " + GlobalTimer.extendScore + " x10";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total score: " + totalScored;
        SetHighScore();
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }
    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);

        theScore.SetActive(true);
        yield return new WaitForSeconds(1);

        totalScore.SetActive(true);
        yield return new WaitForSeconds(1);

        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);

        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
    private void SetHighScore()
    {
        PlayerPrefs.SetInt("TotalScoreCalc", PlayerPrefs.GetInt("TotalScoreCalc") + totalScored);
        if(PlayerPrefs.GetInt("TotalScoreCalc") > PlayerPrefs.GetInt("LevelScore"))
            PlayerPrefs.SetInt("LevelScore", PlayerPrefs.GetInt("TotalScoreCalc"));
    }
}
