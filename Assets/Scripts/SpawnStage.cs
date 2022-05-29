using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStage : MonoBehaviour
{
    // public SaveNotes saveNotes;


    public Transform middle;

    
   
    public GameObject notePrefab;
    private GameObject newNote, nextNote;

    private static bool GameIsPaused;

    public HitDetector hitDetector ;
    

    private string current_song_name; 
    



    void Start()
    {   

        
        current_song_name = PlayerPrefs.GetString("song_name");



        int test = PlayerPrefs.GetInt($"{current_song_name}_AmountOfNotes");

 

        int shouldBeSpawned = 35;
        

   
        for (int i = 1;i < 35;i++){
    
            string x = current_song_name + "_" + i + "_position_x";
            string y = current_song_name + "_" + i + "_position_y";
            string z = current_song_name + "_" + i + "_position_z";

            Vector3 newNotePos =  new Vector3(PlayerPrefs.GetFloat(x), PlayerPrefs.GetFloat(y), PlayerPrefs.GetFloat(z));
  

           newNote = Instantiate(notePrefab, newNotePos, Quaternion.Euler(0, 90, 0));
           PlayerPrefs.SetFloat("dsptime", (float)AudioSettings.dspTime);
 
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
        if (hitDetector.spawedCount < 35 && hitDetector.nextCubeNumber <= PlayerPrefs.GetInt($"{current_song_name}_AmountOfNotes")){
            string x = current_song_name + "_" + hitDetector.nextCubeNumber + "_position_x";
            string y = current_song_name + "_" + hitDetector.nextCubeNumber + "_position_y";
            string z = current_song_name + "_" + hitDetector.nextCubeNumber + "_position_z";

            Vector3 nextNotePos = new Vector3(PlayerPrefs.GetFloat(x), PlayerPrefs.GetFloat(y), PlayerPrefs.GetFloat(z));

            nextNote = Instantiate(notePrefab, nextNotePos, Quaternion.Euler(0, 90, 0));
 
            if (nextNote.transform.position.z > middle.position.z)
            {
                nextNote.name = $"{hitDetector.nextCubeNumber}Q";
            }
            if (nextNote.transform.position.z == middle.position.z)
            {
                nextNote.name = $"{hitDetector.nextCubeNumber}W";
            }
            if (nextNote.transform.position.z < middle.position.z)
            {
                nextNote.name = $"{hitDetector.nextCubeNumber}E";
            }
            hitDetector.spawedCount++;
        }
    }

   
    
}
