using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float enemySpeed;
    float firstEnemySpeed;
    GameObject humanPlayer;
    public float enemySlowDuration;
    private Animator enemyAnim;
    public float fallowRange;
    public float hitRange;
    void Awake()
    {
        enemyAnim = GetComponent<Animator>();
        humanPlayer = GameObject.Find("Human");
        
    }
    void Start()
    {
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

        firstEnemySpeed = enemySpeed;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position,humanPlayer.transform.position) <= fallowRange)
        {
            if (Vector3.Distance(transform.position,humanPlayer.transform.position) >= hitRange)
            {
                fallowPlayer();
            }
        }
    }
    void fallowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, humanPlayer.transform.position , enemySpeed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "slowRange")
        {
            Debug.Log("slow yedi");
            StartCoroutine(slowDuration());
        }
    }

    IEnumerator slowDuration()
    {
        this.enemySpeed = firstEnemySpeed / 2;
        enemyAnim.SetFloat("walkAnimSpeed",0.25f);

        yield return new WaitForSecondsRealtime(enemySlowDuration);
        
        this.enemySpeed = firstEnemySpeed;
        enemyAnim.SetFloat("walkAnimSpeed",1f);
    }
}
