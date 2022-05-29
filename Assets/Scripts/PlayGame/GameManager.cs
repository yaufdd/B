using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    private bool pause;

    public MovePlayer movePlayer;

    private string current_song_name;

    public Canvas canvas;

    public TextMeshProUGUI winMesh, loseMesh;

    public GameObject resultPanel; 
    

    public AudioManager audioManager;

    public bool win, lose;

    private bool gameRsultAudio;

    public float result_persentage;

    
    

    private void Start() {
        current_song_name = PlayerPrefs.GetString("song_name");

        

        winMesh.gameObject.SetActive(false);
        loseMesh.gameObject.SetActive(false);
        resultPanel.SetActive(false);

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
        result_persentage = (movePlayer.points * 100) / (PlayerPrefs.GetInt($"{current_song_name}_AmountOfNotes"));  
        if (movePlayer.points >= (float)(PlayerPrefs.GetInt($"{current_song_name}_AmountOfNotes")) * 0.7f){
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
    
    public void ResultPanel(){
        Cursor.visible = true;

        resultPanel.SetActive(true);

    
    }
}
