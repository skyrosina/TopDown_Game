using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void OnDisable()
    {
        // Sahne deðiþtiðinde müzik otomatik olarak durur.
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
