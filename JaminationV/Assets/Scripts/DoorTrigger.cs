using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    bool isOpened = false;
    bool onedoor;
    bool twodoor;
    int count;
   
    







    void OnTriggerEnter(Collider col)
    {
        door.GetComponent<DoorScript>().count++;


           
        
    }
    private void OnTriggerExit(Collider other)
    {
        door.GetComponent<DoorScript>().count--;
    }



}
