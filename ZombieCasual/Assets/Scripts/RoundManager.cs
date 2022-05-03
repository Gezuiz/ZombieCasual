using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    public Text TextRoundsUI;

    public int ZombiesAlive;
    public int ZombiesThisRound;
    ZombieSpawner ZombieSpawner;

    private int _Rnds;
    public int Rounds
    {
        get { return _Rnds; }
        set
        {
            _Rnds = value;

            TextRoundsUI.text = Rounds.ToString();
        }
    }
    void Update()
    {
        if(ZombiesAlive == 0)
        {
            Rounds += 1;
            ZombiesThisRound += Rounds + 5;
            ZombieSpawner.ZombieSpawn();

            if(ZombiesThisRound > 20)
            {
                ZombiesThisRound = 20;
            }
        }
    }

    void Start()
    {
        Rounds = 1;
        ZombieSpawner = FindObjectOfType<ZombieSpawner>();
    }
}
