using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countobjects : MonoBehaviour
{
    public string nextLevel;
    public GameObject objToDestroy;
    GameObject objUI;
    // Use this for initialization
    void Start()
    {
        objUI = GameObject.Find("ObjectNum");
    }
    // Update is called once per frame
    void Update()
    {
        objUI.GetComponent<Text>().text = thingstopickup.objects.ToString();
        if (thingstopickup.objects == 0)
        {
       
        }

    }
}
