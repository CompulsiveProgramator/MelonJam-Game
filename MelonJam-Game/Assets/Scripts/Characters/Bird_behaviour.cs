using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    The birds event gives ten points ;)
*/
public class Bird_behaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Cat_Movement cat = other.gameObject.GetComponent<Cat_Movement>();
        if(cat != null)
        {
            PointBar_behaviour pb = GameObject.Find("Point bar").GetComponent<PointBar_behaviour>();
            for(int i = 0 ; i < 10 ; i++)
            {
                pb.increasePoints();
            }
        }
    }
}
