using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_behaviour : MonoBehaviour
{
    public AudioClip[] songs; //The songs available to play ;)
    public int numberOfSongs;
    
    public void playRandomSong()
    {
        Debug.Log("Called");
        int aux = Random.Range(0, numberOfSongs);
        Camera.main.GetComponent<AudioSource>().Stop();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(songs[aux]);
    }
}
