using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thingstopickup : MonoBehaviour
{
    public static int objects = 0;

    void Awake ()
    {
        objects++;
    }

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            objects--;
        gameObject.SetActive(false);
    }
}
