using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightCheck : MonoBehaviour
{
    //Points p;
    float timeRemain = 0;

    private void OnTriggerStay(Collider other)
    {
        plusPoint();
    }

    private void plusPoint()
    {
        if (timeRemain > 0)
        {
            timeRemain -= Time.deltaTime;
        }
        else if (timeRemain == 0)
        {
            timeRemain = 100;
            Points.point += 1;
            //print(Points.point);
        }

    }
}
