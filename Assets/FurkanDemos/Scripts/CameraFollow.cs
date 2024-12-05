using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Oyuncunun Transform'u
    private Vector3 offset;   // Kamera ile oyuncu arasýndaki mesafe

    private void Start()
    {

        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset; // Kamera pozisyonunu güncelle
        }
    }
}
