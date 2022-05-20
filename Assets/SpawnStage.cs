using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStage : MonoBehaviour
{
    // public SaveNotes saveNotes;
    public AudioSource song;

    public Transform middle;
    
   
    public GameObject notePrefab;
    private GameObject newNote;

    private static bool GameIsPaused;
    

 


    void Start()
    {
        

        //Debug.Log(PlayerPrefs.GetInt($"{song.name}_AmountOfNotes"));
        for (int i = 1;i < PlayerPrefs.GetInt($"{song.clip.name}_AmountOfNotes");i++){
        //    string x = PlayerPrefs.GetString($"{song.clip.name}") + "_" + i + "_position_x";
        //    string y = PlayerPrefs.GetString($"{song.clip.name}") + "_" + i + "_position_y";
        //    string z = PlayerPrefs.GetString($"{song.clip.name}") + "_" + i + "_position_z";
        //    Debug.Log(x);
        //    Debug.Log(y);
        //    Debug.Log(z);

        string x = song.clip.name + "_" + i + "_position_x";
        string y = song.clip.name + "_" + i + "_position_y";
        string z = song.clip.name + "_" + i + "_position_z";

           Vector3 newNotePos =  new Vector3(PlayerPrefs.GetFloat(x), PlayerPrefs.GetFloat(y),  PlayerPrefs.GetFloat(z));

           newNote = Instantiate(notePrefab, newNotePos, Quaternion.identity);
 
           if (newNote.transform.position.z > middle.position.z)
           {
               newNote.name = $"{i}Q";
           }
           if (newNote.transform.position.z == middle.position.z)
           {
               newNote.name = $"{i}W";
           }
           if (newNote.transform.position.z < middle.position.z)
           {
               newNote.name = $"{i}E";
           }
      
       }
       
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Resume(){
        GameIsPaused = false;
        Time.timeScale = 1;
        song.UnPause();

    }
    public void Pause(){
        GameIsPaused = true;
        Time.timeScale = 0;
        song.Pause();
    }
    
}
