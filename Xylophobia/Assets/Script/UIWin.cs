using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWin : MonoBehaviour
{
    public GameObject UI_Win;
    // Start is called before the first frame update
    void Start()
    {
        UI_Win.SetActive(false);
    }

    public void Winning()
    {
        UI_Win.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void closeWinTab()
    {
        UI_Win.SetActive(false);

    }
}
