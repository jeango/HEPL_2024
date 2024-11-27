using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    public static int score = 0;
    public static int hiScore;
    
    public static void NewGame()
    {
        score = 0;
        SceneManager.LoadScene("Game");
    }

    public static void LoadMainMenu()
    {
        hiScore = PlayerPrefs.GetInt("HiScore");
        SceneManager.LoadScene("MainMenu");
    }

    public static void GameOver()
    {
        var objectsToDestroy = GameObject.FindGameObjectsWithTag("DestroyOnGameOver");
        foreach (var obj in objectsToDestroy)
        {
            GameObject.Destroy(obj);
        }
        if (score > hiScore)
        {
            hiScore = score;
            PlayerPrefs.SetInt("HighScore", hiScore);
            PlayerPrefs.Save();
        }
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}
