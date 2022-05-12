using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public bool playSong;

    public AudioSource audioSong;

    private void Start() {       
        GetComponent<AudioSource>().Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (playSong){
        //     GetComponent<AudioSource>().Play();
        // }
        
        // if (Input.GetKey(KeyCode.W)){
        //     GetComponent<AudioSource>().Play();
        // }
    }


    public void PlayAudio(){
        
        audioSong.Play();

        playSong = true;


    }
}
