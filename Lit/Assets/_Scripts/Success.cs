using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Success : MonoBehaviour {
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(4);
    }
}
