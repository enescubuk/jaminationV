using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float enemySpeed;
    GameObject humanPlayer;
    void Awake()
    {
        humanPlayer = GameObject.Find("Human");
        if (this.gameObject.name == "Enemy1")
        {
            //speed = x;
            //enemySpeed = 0.1f
        }
        if (this.gameObject.name == "Enemy2")
        {
            //speed = x / 2;
            //enemySpeed = 0.1f / 2;
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        fallowPlayer();
    }
    void fallowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, humanPlayer.transform.position , enemySpeed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "slowRange")
        {
            Debug.Log("sea");
        }
    }
}
