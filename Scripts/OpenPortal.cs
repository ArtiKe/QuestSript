using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class OpenPortal : MonoBehaviour
{
    public static float time2 = 0;
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject quest;
    public GameObject objDel;

    
    public GameObject sQuest4;
    
    void Update()
    {
        if (time2 > 0)
        {
            objDel.transform.position = new Vector3(0, -500, 0);
            obj.SetActive(true);
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
            time2 = 0;
            sQuest4.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision myCollision)
    {
        
        if (myCollision.gameObject.name == "ID6")
        {
           
            time2 = 2f;
            obj.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
        }

    }
}
