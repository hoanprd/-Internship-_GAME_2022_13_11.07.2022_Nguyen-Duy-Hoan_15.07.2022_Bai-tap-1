using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControllerL004 : MonoBehaviour
{
    public AudioSource BGM;
    public AudioSource GS1;
    public AudioSource GS2;
    public AudioSource GS3;
    public AudioSource GS4;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume1"))
        {
            PlayerPrefs.SetFloat("musicVolume1", 1);
            Load1();
        }
        else
        {
            Load1();
        }
        if (!PlayerPrefs.HasKey("musicVolume2"))
        {
            PlayerPrefs.SetFloat("musicVolume2", 1);
            Load2();
        }
        else
        {
            Load2();
        }
    }
    private void Load1()
    {
        BGM.volume = PlayerPrefs.GetFloat("musicVolume1");
    }
    private void Load2()
    {
        GS1.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS2.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS3.volume = PlayerPrefs.GetFloat("musicVolume2");
        GS4.volume = PlayerPrefs.GetFloat("musicVolume2");
    }
}
