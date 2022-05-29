using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healBar : MonoBehaviour
{
    public EnemyAI _enemyAI;
    public GameObject skull1, skull2, skull3, eskimo1, eskimo2, eskimo3;

    private void Start()
    {
        _enemyAI.playerHeal = 3;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (_enemyAI.playerHeal == 3)
        {
            skull1.SetActive(false);
            skull2.SetActive(false);
            skull3.SetActive(false);
            eskimo1.SetActive(true);
            eskimo2.SetActive(true);
            eskimo3.SetActive(true);
        }else if (_enemyAI.playerHeal == 2)
        {
            skull1.SetActive(true);
            skull2.SetActive(false);
            skull3.SetActive(false);
            eskimo1.SetActive(false);
            eskimo2.SetActive(true);
            eskimo3.SetActive(true);
        }else if (_enemyAI.playerHeal == 1)
        {
            skull1.SetActive(true);
            skull2.SetActive(true);
            skull3.SetActive(false);
            eskimo1.SetActive(false);
            eskimo2.SetActive(false);
            eskimo3.SetActive(true);
        }else if (_enemyAI.playerHeal <= 0)
        {
            skull1.SetActive(true);
            skull2.SetActive(true);
            skull3.SetActive(true);
            eskimo1.SetActive(false);
            eskimo2.SetActive(false);
            eskimo3.SetActive(false);
            Debug.Log("adam öldü");
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
