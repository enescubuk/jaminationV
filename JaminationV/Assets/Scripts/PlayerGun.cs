using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private Transform firingPoint;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float firingSpeed;
    private float lastShotTime = 0;
    public GameObject sliderCanvas;
    public static PlayerGun Instance;
    public Slider reloadSlider;
    private float totalTime=0;
    private float currentVelocity = 0;
    private float score;
    private float currentScore;
    private bool reloadControl;
    void Awake()
    {
        Instance = GetComponent<PlayerGun>();
    }

    void Update()
    {
        if (reloadControl)
        {
            currentScore = Mathf.SmoothDamp(reloadSlider.value, reloadSlider.maxValue, ref currentVelocity, 100 * Time.deltaTime);
            reloadSlider.value = currentScore;
        }

        if (reloadSlider.value >= (reloadSlider.maxValue)-1)
        {
            reloadControl = false;
            reloadSlider.value = reloadSlider.minValue;
            Debug.Log("sıfırlandı");
            sliderCanvas.SetActive(false);
        }
    }

    public void Shoot()
    {
        if (reloadControl == false)
        {
            
            if (lastShotTime + firingSpeed <= Time.time)
            {
                lastShotTime = Time.time;
                Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
                reloadControl = true;
                sliderCanvas.SetActive(true);
            }
        }
       
        
    }

    
}
