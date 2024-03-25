using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckPlayer : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] ChangeMap ChangeMap;

    static public float map;
    static public float lastNumber;

    float timeRemain = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnTriggerStay(Collider other)
    {
        RandomMap();

        if (other.CompareTag("Player"))
        {
            ChangeCurrentMap();
        }
    }

    public void RandomMap()
    {
        if (timeRemain > 0)
        {
            timeRemain -= Time.deltaTime;
        }
        else if(timeRemain == 0)
        {

            timeRemain = 100;
            map = UnityEngine.Random.Range(1, 30);
            if (map == SceneManager.GetActiveScene().buildIndex || map == lastNumber)
            {
                map = UnityEngine.Random.Range(1, 30);
            }
            lastNumber = map;
            print(map);
        }

        
    }
    private void ChangeCurrentMap()
    {
        if (Points.point == 7)
        {
            ChangeMap.FadeToNextLevel(19);
        }
        /*else if (Points.point == 1)
        {
            ChangeMap.FadeToNextLevel(10);
        }*/
        else
        {
            switch (map)
            {
                case 1:
                    ChangeMap.FadeToNextLevel(1);
                    break;
                case 2:
                    ChangeMap.FadeToNextLevel(2);
                    break;
                case 3:
                    ChangeMap.FadeToNextLevel(3);
                    break;
                case 4:
                    ChangeMap.FadeToNextLevel(4);
                    break;
                case 5:
                    ChangeMap.FadeToNextLevel(5);
                    break;
                case 6:
                    ChangeMap.FadeToNextLevel(6);
                    break;
                case 7:
                    ChangeMap.FadeToNextLevel(7);
                    break;
                case 8:
                    ChangeMap.FadeToNextLevel(8);
                    break;
                case 9:
                    ChangeMap.FadeToNextLevel(9);
                    break;
                case 10:
                    ChangeMap.FadeToNextLevel(10);
                    break;
                case 11:
                    ChangeMap.FadeToNextLevel(11);
                    break;
                case 12:
                    ChangeMap.FadeToNextLevel(12);
                    break;
                case 13:
                    ChangeMap.FadeToNextLevel(13);
                    break;
                case 14:
                    ChangeMap.FadeToNextLevel(14);
                    break;
                case 15:
                    ChangeMap.FadeToNextLevel(15);
                    break;
                case 16:
                    ChangeMap.FadeToNextLevel(16);
                    break;
                case 17:
                    ChangeMap.FadeToNextLevel(17);
                    break;
                case 18:
                    ChangeMap.FadeToNextLevel(18);
                    break;
                default:
                    ChangeMap.FadeToNextLevel(1);
                    break;
            }
        }
        
    }


}
