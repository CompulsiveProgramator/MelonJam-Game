using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            //ToDo Game Over
        }else if(relaxation > 1)
        {
            relaxation--;
            relaxBars[relaxation].SetActive(false);
        }
    }


}
