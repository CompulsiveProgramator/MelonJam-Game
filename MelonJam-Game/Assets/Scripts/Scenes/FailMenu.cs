using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para cambiar de escena

public class FailMenu : MonoBehaviour
{
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) //To go to main menu
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
        else if(Input.GetKeyDown(KeyCode.P)) //To play again
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
