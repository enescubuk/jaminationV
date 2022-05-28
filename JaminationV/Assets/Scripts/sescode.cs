using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sescode : MonoBehaviour
{
    AudioSource SesKaynak;
    public AudioClip kurtSesi;
    void Start()
    {
        SesKaynak = gameObject.GetComponent<AudioSource>();
        Invoke("KurtSesiOynat", 5.0f);
        
    }

 
    void KurtSesiOynat()
    {
        SesKaynak.PlayOneShot(kurtSesi); 
    }
}
