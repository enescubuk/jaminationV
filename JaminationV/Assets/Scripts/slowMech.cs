using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowMech : MonoBehaviour
{
    public float slowRange;
    public GameObject circle;
    // Start is called before the first frame update
    void Awake()
    {
        //circle = GameObject.Find("Slow Range");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            wolfSlow();
        }
    }

    void wolfSlow()
    {
        circle.transform.localScale = new Vector2(slowRange,slowRange);
        StartCoroutine(coolDown());
    }
    IEnumerator coolDown()
    {
        Debug.Log("dalga açti");
        yield return new WaitForSecondsRealtime(0.5f);
        Debug.Log("kapandi");
        circle.transform.localScale = new Vector2(0.5f,0.5f);
        Debug.Log("bitti");
        
        
        Debug.Log("5 saniye cooldown başladi");
        yield return new WaitForSecondsRealtime(5f);
        Debug.Log("cooldown bitti");
    }
}
