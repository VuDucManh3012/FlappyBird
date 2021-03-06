using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameReadyCanvas;
    public GameObject Score;
    private bool play = false;

    private void Start() {
        Time.timeScale = 0; 
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(0);
    }
    public void Play(){
        gameReadyCanvas.SetActive(false);
        Score.SetActive(true);
        Time.timeScale = 1;
    }
}
