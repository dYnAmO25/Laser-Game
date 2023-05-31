using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PlayerLaser : MonoBehaviour
{
    //0 Unbekannt
    //1 Rot
    //2 Blau
    //3 Orange
    //4 Grün
    public int iColor;

    [SerializeField] Light lLight;
    [SerializeField] Volume volume;

    [SerializeField] Color cNothing;
    [SerializeField] ColorParameter cpNothing;
    [SerializeField] Color cRed;
    [SerializeField] ColorParameter cpRed;
    [SerializeField] Color cBlue;
    [SerializeField] ColorParameter cpBlue;
    [SerializeField] Color cOrange;
    [SerializeField] ColorParameter cpOrange;
    [SerializeField] Color cGreen;
    [SerializeField] ColorParameter cpGreen;

    UnityEngine.Rendering.Universal.Vignette vig;

    void Start()
    {
        volume = GameObject.FindGameObjectWithTag("PPV").GetComponent<Volume>();
        
        volume.profile.TryGet<UnityEngine.Rendering.Universal.Vignette>(out vig);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        switch (iColor)
        {
            case 0:
                lLight.color = cNothing;
                //vig.color = cpNothing;
                vig.color.value = cpNothing.value;
                break;
            case 1:
                lLight.color = cRed;
                //vig.color = cpRed;
                vig.color.value = cpRed.value;
                break;
            case 2:
                lLight.color = cBlue;
                //vig.color = cpBlue;
                vig.color.value = cpBlue.value;
                break;
            case 3:
                lLight.color = cOrange;
                //vig.color = cpOrange;
                vig.color.value = cpOrange.value;
                break;
            case 4:
                lLight.color = cGreen;
                vig.color.value = cpGreen.value;
                break;
        }
    }
}
