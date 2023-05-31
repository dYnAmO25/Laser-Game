using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuittingManager : MonoBehaviour
{
    [SerializeField] GameObject goQuitPanel;

    public void OpenQuitPanel()
    {
        goQuitPanel.SetActive(true);
    }

    public void CloseQuitPanel()
    {
        goQuitPanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
