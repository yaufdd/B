using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public Conductor conductor;
     public void LoadStage(string song_name){
        SceneManager.LoadScene("PlayScene");

        PlayerPrefs.SetString("song_name", song_name);
        
     
    }
    public void SetBpm(int bpm){
        PlayerPrefs.SetInt("current_bpm", bpm);
    }

    public void GoChooseSong(){
        SceneManager.LoadScene("ChooseSong");
    }

    public void GoMakeStage(){
        SceneManager.LoadScene("MakeStage");
    }

    public void GoMainMenu(){
        SceneManager.LoadScene("StartMenu");    
    }

    public void GoPlay()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
