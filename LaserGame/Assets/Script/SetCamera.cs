using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCamera : MonoBehaviour
{
    [SerializeField] float fHeight;
    [SerializeField] float fSpeed;
    
    private GameObject goPlayer;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        goPlayer = GameObject.FindGameObjectWithTag("Player");
        Vector3 Position = new Vector3(Mathf.Lerp(transform.position.x, goPlayer.transform.position.x, fSpeed), fHeight, Mathf.Lerp(transform.position.z, goPlayer.transform.position.z, fSpeed));
        transform.position = Position;
    }
}
