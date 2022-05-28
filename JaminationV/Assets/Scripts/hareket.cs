using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class hareket : MonoBehaviour
 
{
      private Rigidbody rb;

[SerializeField]
    int Hiz = 10;


    
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>(); ///fiziksel özellikleri alýnmýþ

    }

    // Update is called once per frame
    void Update()
    {

        float yatay = Input.GetAxis("Vertical");

        float dikey = Input.GetAxis("Horizontal");
        Vector3 hareket = new Vector3(yatay * Hiz, 0.0f, dikey * Hiz);
        rb.AddForce(hareket);//force güç ekle demek
    }

}