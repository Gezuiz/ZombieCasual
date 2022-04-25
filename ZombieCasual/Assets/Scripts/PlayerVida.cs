using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVida : MonoBehaviour
{
    public int Playervida;
    public GameObject[] life;

    public void PlayerDamage(int str)
    {
        Playervida -= str;
        Debug.Log("Jogador" + (Playervida));
    }

    public void Update()
    {
        if(Playervida < 1)
        {
            Destroy(life[0].gameObject);
        }
        else if(Playervida < 2)
        {
            Destroy(life[1].gameObject);
        }
        else if(Playervida < 3)
        {
            Destroy(life[2].gameObject);
        }

        if (Playervida == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}