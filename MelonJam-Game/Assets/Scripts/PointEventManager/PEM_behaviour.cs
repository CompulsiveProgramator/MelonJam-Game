using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEM_behaviour : MonoBehaviour
{
    public GameObject birdPrefab; //To store the bird prefab
    public Vector3 birdSpawnPosition; //To store the spawn position of the bird
    private float lastSpawn; //To store the last time of bird spawn

    // Start is called before the first frame update
    void Start()
    {
        GameObject bird = Instantiate(birdPrefab, birdSpawnPosition, Quaternion.identity);
        lastSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > lastSpawn + 4f)
        {
            GameObject bird = Instantiate(birdPrefab, birdSpawnPosition, Quaternion.identity);
            lastSpawn = Time.time;
        }
    }
}
