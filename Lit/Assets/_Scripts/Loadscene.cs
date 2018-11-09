using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Loadscene : MonoBehaviour
{
    public static bool pauseGame = false;
    public GameObject pauseMenu;
     public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseGame)
            {
                Resume();
            }
            else 
            {
                Pause();
            }
        }
    }
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void QuitGame()
    {
        Debug.Log("QUUuuuuiiIIIIIIIITTTTTTTTT");
        Application.Quit();

    }
    public void Pause()
    {
       
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            pauseGame = true;

    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pauseGame = false;
    }

}
