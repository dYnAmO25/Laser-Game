using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSaver : MonoBehaviour
{
    public int iLevelID;

    public void LoadIDLevel()
    {
        SceneManager.LoadScene(iLevelID);
    }
}
