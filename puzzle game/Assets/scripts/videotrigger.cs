using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videotrigger : MonoBehaviour
{
    public GameObject videoPlayer;

    void Start(){
        videoPlayer.SetActive(false);
        
    }

    void OnTriggerEnter(Collider player){
        if (player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
        }
    }
}
