using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para cambiar de escena

public class UI_behaviour : MonoBehaviour
{
    public GameObject[] relaxBars;
    private const int maxRelaxation = 4;//The max relaxation
    private int relaxation = 4; //The number of initial relaxation bars

    /*
        Method to add a relaxation bar to the UI
    */
    public void addRelaxation()
    {
        if(relaxation < maxRelaxation)
        {
            relaxBars[relaxation].SetActive(true);
            relaxation++;
        }
    }

    public void decreaseRelaxation()
    {
        if(relaxation == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Game over
        }else if(relaxation > 1)
        {
            relaxation--;
            relaxBars[relaxation].SetActive(false);
        }
    }


}
