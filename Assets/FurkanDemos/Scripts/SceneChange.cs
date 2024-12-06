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
        // Sahneyi deðiþtir
        SceneManager.LoadScene("Level"); // Hedef sahne adýný buraya yaz
    }
}
