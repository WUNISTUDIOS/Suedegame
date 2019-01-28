using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightactivate : MonoBehaviour{
    public GameObject light;

    private void OnTriggerEnter(Collider other){
            light.SetActive(true);
        }
    private void OnTriggerExit(Collider other)
    {
        light.SetActive(false);
    }




}
