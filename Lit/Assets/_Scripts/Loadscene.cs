using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Loadscene : MonoBehaviour
{
    public static bool pauseGame = false;
    public GameObject pauseMenu;
    public AudioSource pauseOn;
    public AudioSource pauseOff;
    public AudioSource buttonClick;
    public AudioSource music;

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
        // Debug.Log("QUUuuuuiiIIIIIIIITTTTTTTTT");
        Application.Quit();

    }
    public void Pause()
    {
        music.Pause();
        pauseOn.Play();
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            pauseGame = true;
    }
    public void Resume()
    {
        music.Play();
        pauseOff.Play();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pauseGame = false;
    }

    public void playSound()
    {

        buttonClick.Play();
    }

}
