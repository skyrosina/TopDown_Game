using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinArea : MonoBehaviour
{
    PlayerController pc;
    public GameObject ant;

    private void Start()
    {
        pc = ant.GetComponent<PlayerController>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (pc.followMe == true)
        {
            SceneManager.LoadScene("Win");
            Debug.Log("sik");
        }
    }
}
