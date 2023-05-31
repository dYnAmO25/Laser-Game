using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool bDead;
    public bool bWon;
    public float fSpeed;

    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bDead == false && bWon == false)
        {
            Move();
        }
        else
        {
            rig.velocity = Vector3.zero;
        }
    }

    private void Move()
    {
        Vector3 v3direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        v3direction.Normalize();
        v3direction = v3direction * fSpeed * Time.deltaTime;

        rig.velocity = v3direction;
    }
}
