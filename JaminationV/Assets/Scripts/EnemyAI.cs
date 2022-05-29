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
    public float enemyDamage;
    public int playerHeal = 3;


    int counter = 0;
    void Awake()
    {
        enemyAnim = GetComponent<Animator>();
        humanPlayer = GameObject.Find("Player");
        
    }
    void Start()
    {
        firstEnemySpeed = enemySpeed;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position,humanPlayer.transform.position) <= fallowRange)
        {
            if (Vector3.Distance(transform.position,humanPlayer.transform.position) >= hitRange)
            {
                fallowPlayer();
                //Debug.Log("ustune kosuyor");
                transform.LookAt(humanPlayer.transform);
                enemyAnim.SetBool("enemywalk",true);
                
            }
            else
            {
                
                //Debug.Log("saldiriyor");
                enemyAnim.SetBool("enemywalk",false);
                enemyAnim.SetTrigger("enemyhit");
                //Debug.Log("zinkkk");
                
            }
            
        }
        else
        {
            //Debug.Log("kosmuyor");
            enemyAnim.SetBool("enemywalk",false);
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

    public void damage()
    {
        Debug.Log("geyik saldirdi");
        playerHeal -= 1;
    }
}
