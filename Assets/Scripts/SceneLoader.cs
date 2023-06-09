using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{ 
    AudioSource buttonPress;
    private void Awake() {
        buttonPress = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        buttonPress.Play();
        StaticHelper.stopTimer = false;
        StaticHelper.time = 60;
        Invoke("LoadGameScene", 0.5f);
    }

    public void MainMenu()
    {
        buttonPress.Play();
        Invoke("LoadMainMenuScene", 0.5f);
    }

    public void EditMenu()
    {
        buttonPress.Play();
        Invoke("LoadEditScene", 0.5f);
    }

    public void ExplainMenu()
    {
        buttonPress.Play();
        Invoke("ExplainMenuScene", 0.5f);
    }

    public void EndGameMenu()
    {
        Invoke("EndGameMenuScene", 0.5f);
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    private void LoadEditScene()
    {
        SceneManager.LoadScene(2);
    }

    private void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    private void ExplainMenuScene()
    {
        SceneManager.LoadScene(3);
    }

    private void EndGameMenuScene()
    {
        SceneManager.LoadScene(4);
    }
}
