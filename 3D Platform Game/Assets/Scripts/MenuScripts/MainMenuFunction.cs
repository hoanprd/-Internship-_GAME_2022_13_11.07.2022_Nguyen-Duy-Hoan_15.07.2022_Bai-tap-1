using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject highScoreDisplay;
    public GameObject SettingPanel;
    public GameObject HowToPlayPanel;
    public GameObject Pic1;
    public GameObject Pic2;
    public GameObject Pic3;
    public int highScore;

    private void Start()
    {
        //PlayerPrefs.SetInt("LevelScore", 0);
        PlayerPrefs.SetInt("TotalScoreCalc", 0);
        highScore = PlayerPrefs.GetInt("LevelScore");
        highScoreDisplay.GetComponent<Text>().text = "High Score: " + highScore;
    }
    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void SettingGame()
    {
        buttonPress.Play();
        SettingPanel.SetActive(true);
    }
    public void HowToPlayGame()
    {
        buttonPress.Play();
        HowToPlayPanel.SetActive(true);
    }
    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene(8);
    }
    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }
    public void CloseSettingPanel()
    {
        buttonPress.Play();
        SettingPanel.SetActive(false);
    }
    public void CloseHowToPlayPanel()
    {
        buttonPress.Play();
        HowToPlayPanel.SetActive(false);
    }
    public void GoToPic2()
    {
        buttonPress.Play();
        Pic1.SetActive(false);
        Pic2.SetActive(true);
        Pic3.SetActive(false);
    }
    public void GoToPic3()
    {
        buttonPress.Play();
        Pic1.SetActive(false);
        Pic2.SetActive(false);
        Pic3.SetActive(true);
    }
    public void GoBackPic1()
    {
        buttonPress.Play();
        Pic1.SetActive(true);
        Pic2.SetActive(false);
        Pic3.SetActive(false);
    }
    public void GoBackPic2()
    {
        buttonPress.Play();
        Pic1.SetActive(false);
        Pic2.SetActive(true);
        Pic3.SetActive(false);
    }
}
