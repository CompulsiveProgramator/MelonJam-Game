using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charm_behaviour : MonoBehaviour
{
    private int points = 10;
    
    /*
        Method called if the charm collides with an object
        If it is the cat he gets the points
    */
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Cat_Movement cat = other.gameObject.GetComponent<Cat_Movement>();
        if(cat != null)
        {
            PointBar_behaviour pb = GameObject.Find("UI").GetComponent<PointBar_behaviour>();
            for(int i = 0 ; i < points ; i++)
            {
                pb.increasePoints();
            }
        }
    }
}
