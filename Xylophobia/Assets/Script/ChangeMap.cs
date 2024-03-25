using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMap : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] SetVolumeSlider setVolume;
    private int levelToLoad;
    

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            FadeToNextLevel(1);
        }*/
    }


    public void FadeToNextLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete() 
    {
        SceneManager.LoadScene(levelToLoad);
        setVolume.VtoS();
    }

    

}
