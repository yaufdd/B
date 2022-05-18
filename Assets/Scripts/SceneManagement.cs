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
        Debug.Log($"{PlayerPrefs.GetString("song_name")}");
     
    }
    public void SetBpm(int bpm){
        conductor.bpm = bpm;
    }
}
