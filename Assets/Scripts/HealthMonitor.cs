using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour
{

    public static int HealthValue;
    public int InternalHealth;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject VictoryMessage;


    void Start()
    {
        HealthValue = 0;
    }


    void Update()
    {
        InternalHealth = HealthValue;

        if (HealthValue == 1)
        {
            Heart1.SetActive(true);
        }
        if (HealthValue == 2)
        {
            Heart2.SetActive(true);
        }
        if (HealthValue == 3)
        {
            Heart3.SetActive(true);
            VictoryMessage.SetActive(true);
        }

    }
}