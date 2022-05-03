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
    DoorTeleport Scrpit;
    //public GameObject LeavingRoom;
    //public GameObject GoingRoom;
    //ZombieSpawner ZM_Script;
    //ZombieSpawner ZM_Script2;
    // Start is called before the first frame update
    void Start()
    {
        cameraFollow = FindObjectOfType<CameraFollow>();
        PointsCounter = FindObjectOfType<PointsCounter>();
        Scrpit = NextDoor.GetComponent<DoorTeleport>();
        //ZM_Script = LeavingRoom.GetComponent<ZombieSpawner>();
        //ZM_Script2 = GoingRoom.GetComponent<ZombieSpawner>();

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
                Scrpit.open = true;
                
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
                //LeavingRoom.SetActive(false);
                //GoingRoom.SetActive(true);
                //ZM_Script2.ZombieSpawn();
            }
        
        
        }else if(open == true)
        {
            self.transform.position = exit[0].position;
            //LeavingRoom.SetActive(false);
            //GoingRoom.SetActive(true);
            //ZM_Script2.ZombieSpawn();
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
