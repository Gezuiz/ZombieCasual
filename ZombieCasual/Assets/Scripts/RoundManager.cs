using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    public Text TextRoundsUI;

    public int ZombiesAlive;
    public int ZombiesThisRound;

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
            ZombiesThisRound += 1;
        }
    }

    void Start()
    {
        Rounds = 1;
    }
}
