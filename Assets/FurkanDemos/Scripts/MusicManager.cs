using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource backgroundMusic; // Arka plan m�zi�i i�in
    public AudioSource alarmSound;      // Alarm sesi i�in

    
    
    public void UpdateMusic(bool followMe)
    {
        if (followMe)
        {
            // Arka plan m�zi�ini durdur, alarm sesini ba�lat
            if (backgroundMusic.isPlaying)
                backgroundMusic.Stop();

            if (!alarmSound.isPlaying)
                alarmSound.Play();
        }
        else
        {
            // Alarm sesini durdur, arka plan m�zi�ini ba�lat
            if (alarmSound.isPlaying)
                alarmSound.Stop();

            if (!backgroundMusic.isPlaying)
                backgroundMusic.Play();
        }
    }
}
