using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTeleport : MonoBehaviour
{
    public int DoorNum;
    CameraFollow cameraFollow;
    public Transform[] exit;
    PointsCounter PointsCounter;
    public bool open;
    public GameObject NextDoor;

    // Start is called before the first frame update
    void Start()
    {
        cameraFollow = FindObjectOfType<CameraFollow>();
        PointsCounter = FindObjectOfType<PointsCounter>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TeleportZombie(GameObject self)
    {
        if(open == true)
        {
            self.transform.position = exit[0].position;
        }
        
    }
    public void Teleport(GameObject self)
    {
        if(open == false)
        {
            if (PointsCounter.Points > 200)
            {
                PointsCounter.Points -= 200;
                self.transform.position = exit[0].position;
                open = true;
                if (DoorNum == 1)
                {
                    cameraFollow.RoomChange1();
                }
                else if (DoorNum == 2)
                {
                    cameraFollow.RoomChange2();
                }
                else if (DoorNum == 3)
                {
                    cameraFollow.RoomChange();
                }
                else if (DoorNum == 4)
                {
                    cameraFollow.RoomChange3();
                }
                else if (DoorNum == 5)
                {
                    cameraFollow.RoomChange4();
                }
            }
        
        
        }else if(open == true)
        {
            self.transform.position = exit[0].position;
            if (DoorNum == 1)
            {
                cameraFollow.RoomChange1();
            }
            else if (DoorNum == 2)
            {
                cameraFollow.RoomChange2();
            }
            else if (DoorNum == 3)
            {
                cameraFollow.RoomChange();
            }
            else if (DoorNum == 4)
            {
                cameraFollow.RoomChange3();
            }
            else if (DoorNum == 5)
            {
                cameraFollow.RoomChange4();
            }
        }


    }
}
