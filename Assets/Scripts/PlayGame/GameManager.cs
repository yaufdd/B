using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SaveNotes saveNotes;
    public AudioClip song;

    public List<GameObject> notes = new List<GameObject>();
   
    public GameObject notePrefab;
    private GameObject newNote;


    [SerializeField]
    private Vector3 spawnPos;
    void Start()
    {
  
        Debug.Log(PlayerPrefs.GetInt($"{song.name}_AmountOfNotes"));
       for (int i = 1;i < PlayerPrefs.GetInt($"{song.name}_AmountOfNotes");i++){
           Vector3 newNotePos =  new Vector3(PlayerPrefs.GetFloat($"{song.name}_{i}_position_x"), 
                                            PlayerPrefs.GetFloat($"{song.name}_{i}_position_y"), 
                                            PlayerPrefs.GetFloat($"{song.name}_{i}_position_z"));

           newNote = Instantiate(notePrefab, newNotePos, Quaternion.identity);
           newNote.name = $"{i}";
           notes.Add(newNote);
           
           
       }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
