using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    [SerializeField] GameObject goMenu;

    private GameObject goGameManager;
    private bool bMenu = false;

    private void Start()
    {
        goGameManager = GameObject.FindGameObjectWithTag("GM");
    }

    private void Update()
    {
        if (goGameManager.GetComponent<GameManager>().bDone == false && goGameManager.GetComponent<GameManager>().bDone1 == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                bMenu = !bMenu;
            }
        }
        else
        {
            bMenu = false;
        }

        goMenu.SetActive(bMenu);
    }

    public void DeactivateMenu()
    {
        bMenu = false;
    }
}
