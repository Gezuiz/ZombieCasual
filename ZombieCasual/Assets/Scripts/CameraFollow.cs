using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform Player;
    //public float playerSpeed;
    public Transform [] Pos; 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public void RoomChange()
    {
        transform.position = Pos[0].position;
    }
   
    public void RoomChange1 ()
    {
            transform.position = Pos[1].position;
    }

    public void RoomChange2()
    {
        transform.position = Pos[2].position;
    }

    public void RoomChange3()
    {
        transform.position = Pos[3].position;
    }

    public void RoomChange4()
    {
        transform.position = Pos[4].position;
    }
}
