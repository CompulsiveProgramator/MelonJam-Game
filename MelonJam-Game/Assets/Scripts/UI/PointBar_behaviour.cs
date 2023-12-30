using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; /// DONT FORGET TO ADD THIS LIBRARY, to be able to do the image switching

public class PointBar_behaviour : MonoBehaviour
{
    public Sprite[] numberSprites; //The sprites of all numbers
    public Image[] images; //The images of the points
    private const int numbers = 10; //The amount of numbers [0,1,2,...,9]
    private const int digits = 3; //The number of digits in the points bar
    private int[] points = new int[digits]; //To manage the points in each digit ;)
    private int realPoints = 0; //The points

    /*
        Method used for getting the points of the cat
    */
    public int getPoints()
    {
        return realPoints;
    }

    /*
        Method to increase points of the cat
    */
    public void increasePoints()
    {
        realPoints++;
        points[0]++;
        //
        if(points[0] <= 9)
        {
            images[0].sprite = numberSprites[points[0]];
        }
        if(points[0] > 9)
        {
            points[0] = 0;
            images[0].sprite = numberSprites[points[0]];
            points[1]++;
            //
            if(points[1] <= 9)
            {
                images[1].sprite = numberSprites[points[1]];
            }
            if(points[1] > 9)
            {
                points[1] = 0;
                images[1].sprite = numberSprites[points[1]];
                if(points[2] < 9)
                {
                    points[2]++;
                    //
                    images[2].sprite = numberSprites[points[2]];
                }
            }
        }
    }

    /*
        Method that decreases the points of the cat
    */
    public void decreasePoints()
    {
        realPoints--;
        points[0]--;
        //
        if(points[0] >= 0)
        {
            images[0].sprite = numberSprites[points[0]];
        }
        if(points[0] < 0)
        {
            points[0] = 9;
            images[0].sprite = numberSprites[points[0]];
            points[1]--;
            //
            if(points[1] >= 0)
            {
                images[1].sprite = numberSprites[points[1]];
            }
            if(points[1] < 0)
            {
                points[1] = 9;
                images[1].sprite = numberSprites[points[1]];
                if(points[2] > 0)
                {
                    points[2]--;
                    //
                    images[2].sprite = numberSprites[points[2]];
                }
            }
        }
    }
}
