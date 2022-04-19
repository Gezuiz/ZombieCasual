using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVida : MonoBehaviour
{
    public int Playervida;

    public void PlayerDamage(int str)
    {
        Playervida -= str;
        Debug.Log("Jogador" + (Playervida));
    }
}