using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventsOnce : MonoBehaviour 
{
    public GameObject obj;
    bool eventVisited = false;

    void Start() {
        obj = GameObject.Find("StarEvent Panel");
        if (eventVisited){
            obj.SetActive(false);
        }
        else {
            eventVisited = true;
        }
    }
}
