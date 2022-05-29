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
            Debug.Log("1");
            if (enemy1Heal>0)
            {
                Debug.Log("2");
                enemy1Heal -= 1;
            }
            else
            {
                Debug.Log("3");
                Debug.Log("öldü");
                Destroy(this.gameObject);
                Debug.Log(enemy1Heal);
            }
            
        }
    }
}
