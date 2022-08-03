using UnityEngine;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;


public class OpenFireMag : MonoBehaviour
{
    [Header ("Fire mage")]
    private ParticleSystem witchFire;
    public static bool fireMagic = false;
    public GameObject quest;
    public GameObject ingredient1;
    public GameObject ingredient2;
    public GameObject ingredient3;
    public Sprite fireIcon;
    public Button fireButton;
    int a = 0;
    int b = 0;
    int c = 0;

    [Header("Ice mage")]
    public static bool iceMagic = false;
    public GameObject sQuest10;
    public GameObject quest9;
    public GameObject ingredientIce1;
    public GameObject ingredientIce2;
    public GameObject ingredientIce3;
    public Sprite iceIcon;
    public Button iceButton;
    int d = 0;
    int e = 0;
    int f = 0;

    

    public GameObject sQuest5;

    void Start()
    {
        witchFire = GameObject.Find("witchFire").GetComponent<ParticleSystem>();
        fireMagic = false;
        iceMagic = false;
    }

    void Update()
    {
        if (a == 1 && b == 1 && c == 1)
        {

            fireMagic = true;

           
            fireButton.image.sprite = fireIcon;

            
            ingredient1.SetActive(false);
            ingredient2.SetActive(false);
            ingredient3.SetActive(false);
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
            sQuest5.SetActive(true);
        }

        if (d == 1 && e == 1 && f == 1)
        {

            iceMagic = true;

         
            iceButton.image.sprite = iceIcon;

           
            ingredientIce1.SetActive(false);
            ingredientIce2.SetActive(false);
            ingredientIce3.SetActive(false);
            quest9.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest9.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
            sQuest10.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject == ingredient1) { a = 1;}
        if (myCollision.gameObject == ingredient2) { b = 1;}
        if (myCollision.gameObject == ingredient3) { c = 1;}

        if (myCollision.gameObject == ingredientIce1) { d = 1; }
        if (myCollision.gameObject == ingredientIce2) { e = 1; }
        if (myCollision.gameObject == ingredientIce3) { f = 1; }
    }
    void OnCollisionExit(Collision myCollision)
    {
        if (myCollision.gameObject == ingredient1) { a = 0; }
        if (myCollision.gameObject == ingredient2) { b = 0; }
        if (myCollision.gameObject == ingredient3) { c = 0; }

        if (myCollision.gameObject == ingredientIce1) { d = 0; }
        if (myCollision.gameObject == ingredientIce2) { e = 0; }
        if (myCollision.gameObject == ingredientIce3) { f = 0; }
    }
}
