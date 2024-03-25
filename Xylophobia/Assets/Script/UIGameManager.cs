using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameManager : MonoBehaviour
{
    [SerializeField] ChangeMap ChangeMap;
    [SerializeField] Animator animator;


    public GameObject UI_Pause;
    //public GameObject UI_GameOver;
    //public GameObject UI_GameDone;

    private enum GameUI_State
    {
        GamePlay, GamePause, GameOver, GameDone
    }
    GameUI_State currentState;

    // Start is called before the first frame update
    void Start()
    {
        SwitchUIState(GameUI_State.GamePlay);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseUI();

        }
    }

    private void SwitchUIState(GameUI_State state)
    {
        UI_Pause.SetActive(false);
        //UI_GameDone.SetActive(false);
        //UI_GameOver.SetActive(false);

        Time.timeScale = 1;

        switch (state)
        {
            case GameUI_State.GamePlay:
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                break;
            case GameUI_State.GamePause:
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
                UI_Pause.SetActive(true);
                break;
            /*case GameUI_State.GameDone:
                UI_GameDone.SetActive(true);
                break;*/
        }

        currentState = state;
    }

    public void TogglePauseUI()
    {
        if (currentState == GameUI_State.GamePlay)
        {
            SwitchUIState(GameUI_State.GamePause);
        }
        else if (currentState == GameUI_State.GamePause)
        {
            SwitchUIState(GameUI_State.GamePlay);
        }

    }

    public void Button_MainMenu()
    {
        animator.SetTrigger("FadeMenu");
        Time.timeScale = 1;
        ChangeMap.FadeToNextLevel(0);
    }

    public void Button_Restart()
    {
        ChangeMap.FadeToNextLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void Button_Resume()
    {
        SwitchUIState(GameUI_State.GamePlay);
    }

    /*IEnumerator delayGUIGameisFinish()
    {
        yield return new WaitForSeconds(3f);
        SwitchUIState(GameUI_State.GameDone);
    }*/
    
}
