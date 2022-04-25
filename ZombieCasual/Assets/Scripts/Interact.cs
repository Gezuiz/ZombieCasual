using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private GameObject self;
    void Start()
    {
        self = this.gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door")
        {
            other.gameObject.SendMessage("Teleport", self);
        }
    }
       
}
