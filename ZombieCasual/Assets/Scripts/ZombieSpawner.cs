using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    RoundManager RoundManager;
     public GameObject BadGuy;
    public Vector3 SpawnPosition;
    public int InThisRoom;
    
    
    // Start is called before the first frame update
    void Start()
    {
        RoundManager = FindObjectOfType<RoundManager>();
        ZombieSpawn();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        ZombieSpawn();
    }
   
    public void ZombieSpawn()
    {
        if (RoundManager.ZombiesThisRound > 0)
        {
            Instantiate(BadGuy, SpawnPosition, Quaternion.identity);
            RoundManager.ZombiesThisRound--;
            RoundManager.ZombiesAlive++;
            StartCoroutine(Wait());
        }
    }
}
