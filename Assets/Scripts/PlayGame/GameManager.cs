using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   // public SaveNotes saveNotes;
    public AudioClip song;

    public Transform middle;
    
   
    public GameObject notePrefab;
    private GameObject newNote;


    void Start()
    {
         

        //Debug.Log(PlayerPrefs.GetInt($"{song.name}_AmountOfNotes"));
       for (int i = 1;i < PlayerPrefs.GetInt($"{song.name}_AmountOfNotes");i++){
           Vector3 newNotePos =  new Vector3(PlayerPrefs.GetFloat($"{PlayerPrefs.GetString("song_name")}_{i}_position_x"), 
                                            PlayerPrefs.GetFloat($"{PlayerPrefs.GetString("song_name")}_{i}_position_y"), 
                                            PlayerPrefs.GetFloat($"{PlayerPrefs.GetString("song_name")}_{i}_position_z"));

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
    
}
