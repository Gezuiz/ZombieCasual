using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public Text TextPointsUI;
    
    private int _pts;
    public int Points
    {
        get { return _pts; }
        set
        {
            _pts = value;

            TextPointsUI.text = Points.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Points < 0)
        {
            Points = 0;
        }
    }

}
