using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    PlayerVida PlayerVida;
    
    void start()
    {
        PlayerVida = FindObjectOfType<PlayerVida>();
    }


    public void update()
    {
        slider.value = PlayerVida.Playervida;
    }
 
}
