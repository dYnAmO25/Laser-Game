using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;

public class GetFiles : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] GameObject goPathSaver;

    public string[] sFiles;

    void Start()
    {
        TestFolder();

        SetExplorer();
    }

    public void PlayGame()
    {
        GameObject go1 = GameObject.FindGameObjectWithTag("PathSaver");

        if (go1 != null)
        {
            Destroy(go1);
        }

        go1 = Instantiate(goPathSaver, Vector3.zero, Quaternion.identity);

        go1.GetComponent<SavePath>().sPath = sFiles[dropdown.value];

        DontDestroyOnLoad(go1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetExplorer()
    {
        sFiles = Directory.GetFiles(Application.persistentDataPath + "/CustomLevels");

        dropdown.ClearOptions();

        List<string> sList = new List<string>(sFiles);

        dropdown.AddOptions(sList);
    }

    private void TestFolder()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/CustomLevels"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/CustomLevels");
        }
    }
}
