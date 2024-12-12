using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource backgroundMusic; // Arka plan müziði için
    public AudioSource alarmSound;      // Alarm sesi için

    
    
    public void UpdateMusic(bool followMe)
    {
        if (followMe)
        {
            // Arka plan müziðini durdur, alarm sesini baþlat
            if (backgroundMusic.isPlaying)
                backgroundMusic.Stop();

            if (!alarmSound.isPlaying)
                alarmSound.Play();
        }
        else
        {
            // Alarm sesini durdur, arka plan müziðini baþlat
            if (alarmSound.isPlaying)
                alarmSound.Stop();

            if (!backgroundMusic.isPlaying)
                backgroundMusic.Play();
        }
    }
}
