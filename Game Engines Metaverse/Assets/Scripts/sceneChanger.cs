using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    private void Update()
    {
        reloadGame();
    }

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void replayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }

    void reloadGame()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("RELOADED!");
        }
    }
}
