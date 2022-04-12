using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    RoundManager RoundManager;
     public GameObject BadGuy;
    
    // Start is called before the first frame update
    void Start()
    {
        RoundManager = FindObjectOfType<RoundManager>();
        ZombieSpawn();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        ZombieSpawn();
    }
   
    void ZombieSpawn()
    {
        if (RoundManager.ZombiesThisRound > 0)
        {
            Instantiate(BadGuy, new Vector3(0, 3, 0), Quaternion.identity);
            RoundManager.ZombiesThisRound--;
            RoundManager.ZombiesAlive++;
            StartCoroutine(Wait());
        }
    }
}
