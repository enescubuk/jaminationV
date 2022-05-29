using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{ 
    public void startButton()
    {
        SceneManager.LoadScene("Level1");
    }
    public void quitButton()
    {
        Application.Quit();
    }
}
