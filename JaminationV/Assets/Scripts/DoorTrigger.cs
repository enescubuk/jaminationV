using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    bool isOpened = false;
    public Animator anim => door.GetComponent<Animator>() ; 
    
     

    void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            isOpened = true;
            anim.SetTrigger("open");
            //door.transform.position += new Vector3(0, 4, 0);
        }
    }



}
