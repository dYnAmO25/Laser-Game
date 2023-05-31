using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] int iTrigger;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Trigger")
        {
            if (gameObject.transform.parent.gameObject.GetComponent<LaserScript>().iEnterTrigger == iTrigger)
            {
                //Verloren (Falscher Trigger)
                GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().LostGame();
            }

            gameObject.transform.parent.gameObject.GetComponent<LaserScript>().iEnterTrigger = iTrigger;
        }
    }
}
