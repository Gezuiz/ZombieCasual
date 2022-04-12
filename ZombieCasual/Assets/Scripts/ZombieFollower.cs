using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollower : MonoBehaviour
{
    public Transform Player;
    public float ZombieSpeed;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
        transform.Translate(0.0f, 0.0f, ZombieSpeed * Time.deltaTime);
    }
}

