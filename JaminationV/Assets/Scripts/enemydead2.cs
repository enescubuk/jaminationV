using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydead2 : MonoBehaviour
{
    public GameObject bullet;
    public int enemy2Heal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="bullet")
        {
            if (enemy2Heal>0)
            {
                enemy2Heal -= 1;
            }
            else
            {
                Debug.Log("öldü");
                Debug.Log(enemy2Heal);
            }
            
        }
    }
}
