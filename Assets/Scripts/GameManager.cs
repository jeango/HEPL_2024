using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    public static void NewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}
