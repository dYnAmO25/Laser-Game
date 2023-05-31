using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildLevel : MonoBehaviour
{
    [SerializeField] GameObject goBlock;
    [SerializeField] GameObject goPlayerPrefab;
    [SerializeField] GameObject goGoal;
    [SerializeField] GameObject goBlueLaser;
    [SerializeField] GameObject goRedLaser;

    private float fY = 0.25f;

    void Start()
    {
        string sPath = GameObject.FindGameObjectWithTag("PathSaver").GetComponent<SavePath>().sPath;

        Level data = LoadSystem.LoadLevel(sPath);

        //Builds new Level
        //Builds Ground
        Vector3 v3 = new Vector3();

        GameObject goCurrentBlock = GameObject.FindGameObjectWithTag("Ground");

        v3.x = data.iX;
        v3.y = 0.1f;
        v3.z = data.iZ;
        goCurrentBlock.transform.localScale = v3;

        //Builds Player
        v3.x = data.fXP;
        v3.y = 0.5f;
        v3.z = data.fZP;
        Instantiate(goPlayerPrefab, v3, Quaternion.identity);

        //Builds Blocks
        v3.y = fY;

        for (int i = 0; i < data.position.Length; i += 2)
        {
            v3.x = data.position[i];
            v3.z = data.position[i + 1];

            Instantiate(goBlock, v3, Quaternion.identity);
        }

        //Builds Goals
        for (int i = 0; i < data.goalsPosition.Length; i += 2)
        {
            v3.x = data.goalsPosition[i];
            v3.z = data.goalsPosition[i + 1];

            Instantiate(goGoal, v3, Quaternion.identity);
        }

        //Lasers
        Vector3 v3R = new Vector3();
        Vector3 v3S = new Vector3(2, 0.5f, 0.5f);
        GameObject goCurrentLaser;

        //Builds Blue Laser
        for (int i = 0; i < data.blueLaser.Length; i += 4)
        {
            v3.x = data.blueLaser[i];
            v3.z = data.blueLaser[i + 1];
            v3R.y = data.blueLaser[i + 2];
            v3S.x = data.blueLaser[i + 3];

            goCurrentLaser = Instantiate(goBlueLaser, v3, Quaternion.Euler(v3R));
            goCurrentLaser.transform.localScale = v3S;
        }

        //Builds Red Laser
        for (int i = 0; i < data.redLaser.Length; i += 4)
        {
            v3.x = data.redLaser[i];
            v3.z = data.redLaser[i + 1];
            v3R.y = data.redLaser[i + 2];
            v3S.x = data.redLaser[i + 3];

            goCurrentLaser = Instantiate(goRedLaser, v3, Quaternion.Euler(v3R));
            goCurrentLaser.transform.localScale = v3S;
        }
    }
}
