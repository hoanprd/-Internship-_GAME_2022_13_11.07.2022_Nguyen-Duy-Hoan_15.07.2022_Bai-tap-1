using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    public static int redirectToLevel;
    public static int nextLevel;

    // Update is called once per frame
    void Update()
    {
        if (redirectToLevel == 3)
            SceneManager.LoadScene(redirectToLevel);
        else if (redirectToLevel == 4)
            SceneManager.LoadScene(redirectToLevel);
        else if (redirectToLevel == 5)
            SceneManager.LoadScene(redirectToLevel);
        else if (redirectToLevel == 6)
            SceneManager.LoadScene(redirectToLevel);
        else if (redirectToLevel == 7)
            SceneManager.LoadScene(redirectToLevel);
    }
}
