using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sescode : MonoBehaviour
{
    public AudioSource SesKaynak;
    public AudioClip kurtSesi;
    void Start()
    {
        SesKaynak = gameObject.GetComponent<AudioSource>();
    }
    public void playSoundWolf()
    {
        SesKaynak.PlayOneShot(kurtSesi); 
    }
}
