using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydead : MonoBehaviour
{
    public GameObject bullet;
    public int enemy1Heal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="bullet")
        {
            if (enemy1Heal>0)
            {
                enemy1Heal -= 1;
            }
            else
            {
                Debug.Log("öldü");
                Debug.Log(enemy1Heal);
            }
            
        }
    }
}
