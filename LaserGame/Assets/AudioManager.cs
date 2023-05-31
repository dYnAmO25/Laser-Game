using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            source.volume = PlayerPrefs.GetFloat("Music");
        }
        else
        {
            source.volume = 0.5f;
        }
    }
}
