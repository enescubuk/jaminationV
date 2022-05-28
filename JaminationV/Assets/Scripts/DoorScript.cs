using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public int count;
    public int aim;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (count==aim)
        {
            GetComponent<Animator>().SetTrigger("open");

        }
        
    }
}
