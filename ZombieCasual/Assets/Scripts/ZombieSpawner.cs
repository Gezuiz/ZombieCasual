using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    RoundManager RoundManager;
     public GameObject BadGuy;
    public Vector3[] SpawnPosition;
    public int Window;
    
    
    // Start is called before the first frame update
    void Awake()
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
            Window = Random.Range(1, 5);
            Instantiate(BadGuy, SpawnPosition[Window], Quaternion.identity);
            RoundManager.ZombiesThisRound--;
            RoundManager.ZombiesAlive++;
            StartCoroutine(Wait());
        }
    }
}
