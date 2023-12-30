using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEM_behaviour : MonoBehaviour
{
    public GameObject charmPrefab; //To store the charm prefab
    public Vector3[] charmSpawnPosition; //To store the spawn position of the charm
    public int nSpawnPos; //To know the number of spawn positions
    private float lastSpawn; //To store the last time of charm spawn
    private float lapse = 40f; //To store the time lapse between spawns

    void Start()
    {
        int pos = Random.Range(0, nSpawnPos);
        GameObject bird = Instantiate(charmPrefab, charmSpawnPosition[pos], Quaternion.identity);
        lastSpawn = Time.time;
    }

    void Update()
    {
        if(Time.time > lastSpawn + lapse)
        {
            int pos = Random.Range(0, nSpawnPos);
            GameObject bird = Instantiate(charmPrefab, charmSpawnPosition[pos], Quaternion.identity);
            lastSpawn = Time.time;
        }
    }
}
