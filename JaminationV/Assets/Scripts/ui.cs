using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{ 
    public void startButton()
    {
        SceneManager.LoadScene("Polish");
    }
    public void quitButton()
    {
        Application.Quit();
    }
}
