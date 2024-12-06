using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Button playButton;

    private void Start()
    {
        playButton.onClick.AddListener(changeScene);
    }

    void changeScene()
    {
        // Sahneyi de�i�tir
        SceneManager.LoadScene("Level"); // Hedef sahne ad�n� buraya yaz
    }
}
