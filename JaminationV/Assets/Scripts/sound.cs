using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sound : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Music");
        if (obj.Length >1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
