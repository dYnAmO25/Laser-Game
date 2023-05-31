using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();

        if (PlayerPrefs.HasKey("Music"))
        {
            slider.value = PlayerPrefs.GetFloat("Music");
        }
        else
        {
            slider.value = 0.5f;
        }
    }

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("Music", slider.value);
    }
}
