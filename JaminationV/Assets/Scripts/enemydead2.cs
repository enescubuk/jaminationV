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
            Debug.Log(" 1");
            if (enemy2Heal>0)
            {
                Debug.Log("2");
                enemy2Heal -= 1;
            }
            else
            {
                Debug.Log("3");
                Debug.Log("öldü");
                Destroy(this.gameObject);
                Debug.Log(enemy2Heal);
            }
            
        }
    }
}
