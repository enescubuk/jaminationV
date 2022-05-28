using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfControl : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 forward;
    private Vector3 right;
    private Animator wolfAnimator;
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        wolfAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Move();
        }
        animationController();
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 rightMovement = right * speed * Time.deltaTime * Input.GetAxis("Horizontal");

        Vector3 upMovement = forward * speed * Time.deltaTime * Input.GetAxis("Vertical");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);
        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }

    void animationController()
    {
        
    }
}
