using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audios;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switchTime(audios);
    }

    void switchTime(AudioClip audios)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = audios;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
