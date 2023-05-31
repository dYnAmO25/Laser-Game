using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] GameObject goMusicPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("MusicPlayer");

        if (go == null)
        {
            Instantiate(goMusicPlayer, Vector3.zero, Quaternion.identity);
        }
    }
}
