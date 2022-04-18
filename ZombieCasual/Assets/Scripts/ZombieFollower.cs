using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollower : MonoBehaviour
{
    public Transform Following;
    public float ZombieSpeed;
    GameObject player;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Following = GameObject.FindGameObjectWithTag("SubPlayer").transform;
        transform.LookAt(Following);
        transform.Translate(0.0f, 0, ZombieSpeed * Time.deltaTime);
    }
}

