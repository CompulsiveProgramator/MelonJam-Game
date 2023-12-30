using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owner_behaviour : MonoBehaviour
{
    private float timeLapse = 10f; //The time gaps the owner checks if there is music playing
    private float lastCheck; //To know when owner last checked for music
    public GameObject UI; //The UI
    private UI_behaviour UIbh; //The UI behaviour script

    //Called before first frame
    private void Start() {
        UIbh = UI.GetComponent<UI_behaviour>();
        if(Camera.main.GetComponent<AudioSource>().isPlaying)
        {
            UIbh.addRelaxation();
        }
        else
        {
            UIbh.decreaseRelaxation();
        }

        lastCheck = Time.time;
    }

    //Called once per frame ;)
    private void Update() {
        if(Time.time > lastCheck + timeLapse)
        {
            if(Camera.main.GetComponent<AudioSource>().isPlaying)
            {
                UIbh.addRelaxation();
            }
            else
            {
                UIbh.decreaseRelaxation();
            }
            lastCheck = Time.time;
        }
    }
}
