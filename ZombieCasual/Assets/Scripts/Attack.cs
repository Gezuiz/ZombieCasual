using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int Str;
    private GameObject self;
    public Animator anim;
 
    void Start()
    {
        self = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            anim.SetTrigger("Deu Dano");
            other.gameObject.SendMessage("Damage", Str);
        }
        //else if(other.tag == "Door")
        //{
            //other.gameObject.SendMessage("Teleport", self);
        //}
        
    }
}
