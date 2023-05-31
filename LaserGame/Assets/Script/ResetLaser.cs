using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLaser : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trigger")
        {
            gameObject.transform.parent.gameObject.GetComponent<LaserScript>().iEnterTrigger = 0;
        }
    }
}
