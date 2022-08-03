using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open3rdDoor : MonoBehaviour
{
    public GameObject quest;
    public GameObject Door;

    public GameObject Witch;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision myCollision)
    {
        // определение столкновения с двумя разноименными объектами
        if (myCollision.gameObject.tag == "Ice Magic")
        {
            Witch.SetActive(true);
            Door.SetActive(false);
            quest.GetComponent<Text>().fontStyle = FontStyle.Italic;
            quest.GetComponent<Text>().color = new Color(0.2f, 0.2f, 0.2f, 0.4f);
        }
    }
}
