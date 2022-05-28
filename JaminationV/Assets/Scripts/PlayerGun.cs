using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private Transform firingPoint;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float firingSpeed;
    private float lastShotTime = 0;
    
    public static PlayerGun Instance;
    
    
    void Awake()
    {
        Instance = GetComponent<PlayerGun>();
    }

    void Update()
    {
        
    }

    public void Shoot()
    {
        if (lastShotTime + firingSpeed <= Time.time)
        {
            lastShotTime = Time.time;
            Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
        }
        
    }
}
