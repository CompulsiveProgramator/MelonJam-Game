using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_behaviour : MonoBehaviour
{
    public GameObject Cat;

    void Update()
    {
        if(Cat == null) return;
        
        Vector3 position = transform.position;
        position.x = Cat.transform.position.x;
        position.y = Cat.transform.position.y;
        transform.position = position;
    }
}
