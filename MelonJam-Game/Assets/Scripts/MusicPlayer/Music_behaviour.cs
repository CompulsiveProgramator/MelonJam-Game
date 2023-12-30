using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_behaviour : MonoBehaviour
{
    public AudioClip[] songs; //The songs available to play ;)
    public int numberOfSongs;
    private int currentSong = 0;
    
    public void playRandomSong()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(songs[currentSong]);
        currentSong = (currentSong + 1)%numberOfSongs;
    }
}
