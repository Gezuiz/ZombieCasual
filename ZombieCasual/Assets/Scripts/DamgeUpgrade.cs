using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamgeUpgrade : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float speed;
    PointsCounter pointsCounter;
    Attack attack;
    [SerializeField] private int price;

    void Start()
    {
        pointsCounter = FindObjectOfType<PointsCounter>();
        attack = FindObjectOfType<Attack>();
    }


    void Update()
    {
        transform.Rotate(rotation * speed * Time.deltaTime);
    }

    public void Teleport()
    {
        if(pointsCounter.Points > price)
        {
            pointsCounter.Points -= price;
            attack.Str += 1;
            Destroy(gameObject);
        }
    }
}
