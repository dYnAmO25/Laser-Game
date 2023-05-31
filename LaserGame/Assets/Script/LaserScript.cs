using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    [SerializeField] GameObject FirstCollider;
    [SerializeField] GameObject SecondCollider;

    [SerializeField] Material mRed;
    [SerializeField] Material mBlue;

    [SerializeField] bool bRed;

    [SerializeField] AudioSource asLaser1;
    [SerializeField] AudioSource asLaser2;
    
    private GameObject goPlayer;

    public int iEnterTrigger;

    void Start()
    {
        goPlayer = GameObject.FindGameObjectWithTag("Player");

        if (bRed)
        {
            GetComponent<MeshRenderer>().material = mRed;
        }
        else
        {
            GetComponent<MeshRenderer>().material = mBlue;
        }
               
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger")
        {
            if (bRed)
            {
                if (goPlayer.GetComponent<PlayerLaser>().iColor == 1)
                {
                    GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().LostGame();
                }

                goPlayer.GetComponent<PlayerLaser>().iColor = 1;

                asLaser1.Play();
            }
            else
            {
                if (goPlayer.GetComponent<PlayerLaser>().iColor == 2)
                {
                    GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().LostGame();
                }

                goPlayer.GetComponent<PlayerLaser>().iColor = 2;

                asLaser2.Play();
            }
        }
    }
}
