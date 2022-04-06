using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform MouseBall;
    public float playerSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(MouseBall);
        transform.Translate(0.0f, 0.0f, playerSpeed * Time.deltaTime);
    }
}
