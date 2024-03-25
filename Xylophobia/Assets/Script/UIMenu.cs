using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    [SerializeField] ChangeMap ChangeMap;

    public GameObject UI_Setting;
    public GameObject UI_Credit;

    public AudioMixer AudioMixer;
    public float AudioVolume;

    public enum SettingState
    {
        isOff, isOn
    } 
    public SettingState currentState;

    public enum CreditState
    {
        isCredit, isCreditoff
    }
    public CreditState nowState;

    private void Start()
    {
        SwitchUIState(SettingState.isOff);
        SwitchCreditState(CreditState.isCreditoff);
        SetFullScreen(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(currentState == SettingState.isOn)
            {
                ToggleSettingUI();
            }

            if (nowState == CreditState.isCredit)
            {
                ToggleCreditUI();
            }

        }
    }

    public void Button_Start()
    {
        ChangeMap.FadeToNextLevel(1);
    }

    public void Button_Exit() 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void Button_Setting()
    {
        ToggleSettingUI();
    }

    public void ButtonCredit()
    {
        ToggleCreditUI();
    }

    private void SwitchUIState(SettingState state)
    {
        UI_Setting.SetActive(false);
        
        switch (state)
        {
            case SettingState.isOff:
                break; 
            case SettingState.isOn:
                UI_Setting.SetActive(true);
                break;
        }
        currentState = state;

    }

    public void ToggleSettingUI()
    {
        if (currentState == SettingState.isOff)
        {
            SwitchUIState(SettingState.isOn);
        }
        else if (currentState == SettingState.isOn)
        {
            SwitchUIState(SettingState.isOff);
        }

    }

    private void SwitchCreditState(CreditState state2)
    {
        UI_Credit.SetActive(false);

        switch (state2)
        {
            case CreditState.isCredit:
                UI_Credit.SetActive(true);
                break;
            case CreditState.isCreditoff:
                break;
        }
        nowState = state2;

    }
    public void ToggleCreditUI()
    {
        if (nowState == CreditState.isCreditoff)
        {
            SwitchCreditState(CreditState.isCredit);
        }
        else if (nowState == CreditState.isCredit)
        {
            SwitchCreditState(CreditState.isCreditoff);
        }

    }

    public void SetFullScreen(bool isFullScreen)
        {
            Screen.fullScreen = isFullScreen;
        }


    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("volume",volume);
        AudioVolume = volume;
    }
}
