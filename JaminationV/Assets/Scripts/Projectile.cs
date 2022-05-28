using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 firingPoint;

    [SerializeField] private float projectileSpeed;
    [SerializeField] private float maxProjectileDistance;
    void Start()
    {
        firingPoint = transform.position;
    }

    void Update()
    {
        MoveProjectile();
    }

    void MoveProjectile()
    {
        transform.Translate(Vector3.left * projectileSpeed * Time.deltaTime);
    }
}
