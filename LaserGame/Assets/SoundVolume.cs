using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolume : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    
    private Slider slider;
    private AudioSource source;
    private bool bDone = false;

    void Start()
    {
        slider = GetComponent<Slider>();
        source = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("Volume"))
        {
            slider.value = PlayerPrefs.GetFloat("Volume");
        }
        else
        {
            slider.value = 0.5f;
        }
    }

    public void TestSound()
    {
        if (!source.isPlaying)
        {
            if (bDone)
            {
                source.clip = clip;
            }

            bDone = true;

            source.Play();
        }
    }

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
        AudioListener.volume = slider.value;
    }
}
