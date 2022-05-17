using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveNotes : MonoBehaviour
{
    private int numberOfNote;
    public int amountOfNote;

    public AudioClip music;

    public Conductor conductor;

    public GameObject cube;

    

    public Transform Qdetector;
    public Transform Wdetector;
    public Transform Edetector;


    [SerializeField] private float offsetX, offsetY;


    

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        numberOfNote = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)){
            numberOfNote++;
            amountOfNote = numberOfNote;
            Vector3 potencial_Q_note_pos = new Vector3(Qdetector.position.x, Qdetector.position.y, Qdetector.position.z);
            SaveNotePotencialPos($"{music.name}_{numberOfNote}_position", potencial_Q_note_pos.x, potencial_Q_note_pos.y, potencial_Q_note_pos.z);
            SaveBeatOfNote($"{music.name}_{numberOfNote}Q_beatsOfNote", conductor.beatOfThisNote);
            Instantiate(cube, potencial_Q_note_pos, Quaternion.identity);
  

        }
         if (Input.GetKeyDown(KeyCode.W)){
            numberOfNote++;
            amountOfNote = numberOfNote;
            Vector3 potencial_W_note_pos = new Vector3(Wdetector.position.x, Wdetector.position.y, Wdetector.position.z);
            SaveNotePotencialPos($"{music.name}_{numberOfNote}_position", potencial_W_note_pos.x, potencial_W_note_pos.y, potencial_W_note_pos.z);
            SaveBeatOfNote($"{music.name}_{numberOfNote}W_beatsOfNote", conductor.beatOfThisNote);
            Instantiate(cube, potencial_W_note_pos, Quaternion.identity);


        }
         if (Input.GetKeyDown(KeyCode.E)){
            numberOfNote++;
            amountOfNote = numberOfNote;
            Vector3 potencial_E_note_pos = new Vector3(Edetector.position.x, Edetector.position.y, Edetector.position.z);
            SaveNotePotencialPos($"{music.name}_{numberOfNote}_position", potencial_E_note_pos.x, potencial_E_note_pos.y, potencial_E_note_pos.z);
            SaveBeatOfNote($"{music.name}_{numberOfNote}E_beatsOfNote", conductor.beatOfThisNote);
            Instantiate(cube, potencial_E_note_pos, Quaternion.identity);
 
        }
        
    }

    private void SaveNotePotencialPos(string note_info, float x, float y, float z)
    {
        PlayerPrefs.SetFloat($"{note_info}_x", x);
        PlayerPrefs.SetFloat($"{note_info}_y", y);
        PlayerPrefs.SetFloat($"{note_info}_z", z);
        PlayerPrefs.Save();
        Debug.Log($"{note_info}_x_y_z was saved successfully");
    }
    private void SaveBeatOfNote(string note_info, float beatsOfNote){
        PlayerPrefs.SetFloat($"{note_info}", beatsOfNote);
        Debug.Log($"{beatsOfNote} is saved");
    }

    public  void SaveAmountOfSongNotes(){
        PlayerPrefs.SetInt($"{music.name}_AmountOfNotes", amountOfNote);
        Debug.Log($"Amount = {amountOfNote} saved");
    }

    public void DeleteAllData(){
        PlayerPrefs.DeleteAll();
        Debug.Log("Data reest");
    }
}
