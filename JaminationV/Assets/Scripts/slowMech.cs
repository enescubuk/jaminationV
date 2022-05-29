using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowMech : MonoBehaviour
{
    public float slowRange;
    public GameObject circle;

    public float skillDuration , skillCoolDown;

    Vector2 firstScale;
    // Start is called before the first frame update
    void Awake()
    {
        //circle = GameObject.Find("Slow Range");
    }
    void Start()
    {
        firstScale = circle.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            wolfSlow();
            GameObject.Find("soundController").GetComponent<sescode>().playSoundWolf();
        }
    }

    public void wolfSlow()
    {
        circle.transform.localScale = new Vector2(slowRange,slowRange);
        StartCoroutine(coolDown());
    }
    IEnumerator coolDown()
    {
        //dalga açtı
        yield return new WaitForSecondsRealtime(skillDuration);
        circle.transform.localScale = firstScale;
        //dalga kapandı
        

        Debug.Log("5 saniye cooldown başladi");
        yield return new WaitForSecondsRealtime(skillCoolDown - skillDuration);
        Debug.Log("cooldown bitti");
    }
}
