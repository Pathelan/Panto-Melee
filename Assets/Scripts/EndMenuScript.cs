using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuScript : MonoBehaviour
{
    public GameObject MainMenuReturn;
    public GameObject PlayAgain;

    public void MenuReturnButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuScene");
    }

    public void PlayAgainButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Stage");
    }
}
