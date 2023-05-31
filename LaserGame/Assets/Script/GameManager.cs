using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject goDeathEffect;
    [SerializeField] GameObject goWinEffect;
    [SerializeField] GameObject goWinScreen;
    [SerializeField] GameObject goLoseScreen;

    public bool bDone = false;
    public bool bDone1 = false;
    
    public void LostGame()
    {
        if (!bDone)
        {
            Debug.Log("Lost");

            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().bDead = true;

            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLaser>().iColor = 3;

            Vector3 v3Spawn = GameObject.FindGameObjectWithTag("Player").transform.position;

            GameObject.FindGameObjectWithTag("Player").GetComponent<MeshRenderer>().enabled = false;
            //Destroy(GameObject.FindGameObjectWithTag("Player"));

            Instantiate(goDeathEffect, v3Spawn, Quaternion.identity);

            goLoseScreen.SetActive(true);

            bDone = true;
        }
    }

    public void WonGame()
    {
        if (!bDone1)
        {
            Debug.Log("Won");

            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().bWon = true;

            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLaser>().iColor = 4;

            Vector3 v3Spawn = GameObject.FindGameObjectWithTag("Player").transform.position;

            GameObject.FindGameObjectWithTag("Player").GetComponent<MeshRenderer>().enabled = false;

            Instantiate(goWinEffect, v3Spawn, Quaternion.identity);

            goWinScreen.SetActive(true);

            bDone1 = true;
        }
    }
}
