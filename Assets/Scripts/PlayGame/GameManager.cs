using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    private bool pause;

    public MovePlayer movePlayer;

    private string current_song_name;

    public Canvas canvas;

    public TextMeshProUGUI winMesh, loseMesh;
    

    public AudioManager audioManager;

    public bool win, lose;

    private bool gameRsultAudio;

    
    

    private void Start() {
        current_song_name = PlayerPrefs.GetString("song_name");

        winMesh.gameObject.SetActive(false);
        loseMesh.gameObject.SetActive(false);

        pause = false;
        gameRsultAudio = false;
        win = false;
        lose  = false;
        
    }
    private void Update() {
        if (Input.GetKey(KeyCode.Escape)){
            pause = !pause;   
        }
        if (!pause){
            Time.timeScale = 1;
        }
        else{
            Time.timeScale = 0;
        }

       
        if (!audioManager.audioIsPlaying){
            GameResult();
            if(!gameRsultAudio){
                AudioGameResult();
            }   
        }

        
        
        
        
    }

    private void GameResult(){      

        if (movePlayer.points >= (PlayerPrefs.GetInt($"{current_song_name}_AmountOfNotes") / 2)){
            winMesh.gameObject.SetActive(true);   
            win = true;        
            
            
        }
        else{
            loseMesh.gameObject.SetActive(true);
            lose = true;
        }

        

    }

    public void AudioGameResult(){  
        if (win){
            FindObjectOfType<AudioManager>().PlaySound("Win");
        }
        else{
            FindObjectOfType<AudioManager>().PlaySound("Lose");
        }
        gameRsultAudio = true;
        
    }
    
}
