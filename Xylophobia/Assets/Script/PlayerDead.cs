using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] ChangeMap ChangeMap;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BoxDamage"))
        {
            ChangeMap.FadeToNextLevel(Random.Range(1, 14));
            Points.point = 0;

        }
    }
}
