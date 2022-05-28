using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 5f;
    private BoxCollider _collider;
    private Vector3 forward;
    private Vector3 right;
    private Animator playerAnim;
    void Start()
    {
        _collider = GetComponent<BoxCollider>();
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            Move();
        }
        animationController();
        HandleRotationInput();
        HandleShootInput();
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            other.isTrigger = true;
        }
    }

    void HandleRotationInput()
    {
        RaycastHit _hit;
        Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray,out _hit))
        {
            transform.LookAt(new Vector3(_hit.point.x,transform.position.y,_hit.point.z));
        }
    }
    void animationController()
    {
        
    }

    void HandleShootInput()
    {
        if (Input.GetButton("Fire1"))
        {
            PlayerGun.Instance.Shoot();
        }
    }
}
