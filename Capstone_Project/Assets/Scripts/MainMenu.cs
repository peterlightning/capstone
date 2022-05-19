using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button gameStartButton;
    public Button gameQuitButton;
    public string newGameSceneName;
    public GameObject loadGameMenu;

    public void Awake()
    {
        gameStartButton.onClick.AddListener(NewGame);
        gameQuitButton.onClick.AddListener(ExitGame);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(newGameSceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
