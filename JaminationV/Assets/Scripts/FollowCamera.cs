using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 0.28f, -7.23f);
    }
}
