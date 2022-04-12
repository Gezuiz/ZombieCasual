using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public int vida;
    PointsCounter PointsCounter;
    RoundManager roundManager;
    
    // Start is called before the first frame update
    void Start()
    {
        PointsCounter = FindObjectOfType<PointsCounter> ();
        roundManager = FindObjectOfType<RoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vida == 0)
        {
            PointsCounter.Points += 60;
            roundManager.ZombiesAlive--;
            Destroy(gameObject);
        }
    }

    public void Damage(int str)
    {
        vida -= str;
        Debug.Log(vida);
        PointsCounter.Points += 10;
    }
}
