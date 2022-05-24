using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStage : MonoBehaviour
{
    // public SaveNotes saveNotes;


    public Transform middle;

    
   
    public GameObject notePrefab;
    private GameObject newNote;

    private static bool GameIsPaused;
    

 


    void Start()
    {
        string current_song_name = PlayerPrefs.GetString("song_name");

        Debug.Log(current_song_name);

        bool test = PlayerPrefs.HasKey($"{current_song_name}_AmountOfNotes");
        Debug.Log(test);
        

   
        for (int i = 1;i < PlayerPrefs.GetInt($"{current_song_name}_AmountOfNotes");i++){
    
            string x = current_song_name + "_" + i + "_position_x";
            string y = current_song_name + "_" + i + "_position_y";
            string z = current_song_name + "_" + i + "_position_z";

            

           
           

            Vector3 newNotePos =  new Vector3(PlayerPrefs.GetFloat(x), PlayerPrefs.GetFloat(y), PlayerPrefs.GetFloat(z));
            Debug.Log($"{newNotePos.x}-x/{newNotePos.y}-y/{newNotePos.z}-z");

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

    //private void Update() {
    //    if (Input.GetKeyDown(KeyCode.Escape)){
    //        if (GameIsPaused){
    //            Resume();
    //        }
    //        else{
    //            Pause();
    //        }
    //    }
    //}

    //public void Resume(){
    //    GameIsPaused = false;
    //    Time.timeScale = 1;
    //    song.UnPause();

    //}
    //public void Pause(){
    //    GameIsPaused = true;
    //    Time.timeScale = 0;
    //    song.Pause();
    //}
    
}
