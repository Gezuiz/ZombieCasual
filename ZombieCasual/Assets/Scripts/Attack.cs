using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int Str;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Enemy)
    {
        Debug.Log("Macetou");
        Enemy.gameObject.SendMessage("Damage",Str);
    }
}
