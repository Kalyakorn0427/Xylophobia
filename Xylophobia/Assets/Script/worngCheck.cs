using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worngCheck : MonoBehaviour
{
    float timeRemain = 0;

    private void OnTriggerStay(Collider other)
    {
        deletePoint();
    }

    private void deletePoint()
    {
        if (timeRemain > 0)
        {
            timeRemain -= Time.deltaTime;
        }
        else if (timeRemain == 0)
        {
            timeRemain = 100;
            Points.point = 0;
            //print(Points.point);
        }

    }
}
