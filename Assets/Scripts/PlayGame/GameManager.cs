using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   // public SaveNotes saveNotes;
    public AudioClip song;

    public Transform QPos, WPos, EPos;
    
   
    public GameObject notePrefab;
    private GameObject newNote;






    void Start()
    {
         Debug.Log(QPos.position.z);
         Debug.Log(WPos.position.z);
         Debug.Log(EPos.position.z);

        //Debug.Log(PlayerPrefs.GetInt($"{song.name}_AmountOfNotes"));
       for (int i = 1;i < PlayerPrefs.GetInt($"{song.name}_AmountOfNotes");i++){
           Vector3 newNotePos =  new Vector3(PlayerPrefs.GetFloat($"{song.name}_{i}_position_x"), 
                                            PlayerPrefs.GetFloat($"{song.name}_{i}_position_y"), 
                                            PlayerPrefs.GetFloat($"{song.name}_{i}_position_z"));

           newNote = Instantiate(notePrefab, newNotePos, Quaternion.identity);           
           if (newNote.transform.position.z == QPos.position.z)
           {
               newNote.name = $"{i}Q";
           }
           if (newNote.transform.position.z == WPos.position.z)
           {
               newNote.name = $"{i}W";
           }
           if (newNote.transform.position.z == EPos.position.z)
           {
               newNote.name = $"{i}E";
           }
           
          
           
           
       }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
