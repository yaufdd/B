using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SaveNotes : MonoBehaviour
{
    private int numberOfNote;
    public int amountOfNote;

    public AudioSource music;


    public Conductor conductor;

    public GameObject cube;

    private string current_song_name;

    

    public Transform Qdetector;
    public Transform Wdetector;
    public Transform Edetector;


    [SerializeField] private float offsetX, offsetY;


    

    void Start()
    {
        numberOfNote = 0;

        current_song_name = PlayerPrefs.GetString("song_name");

        Refresh();

        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)){
            numberOfNote++;
            amountOfNote = numberOfNote;
            Vector3 potencial_Q_note_pos = new Vector3(Qdetector.position.x, Qdetector.position.y, Qdetector.position.z);

            SaveNotePotencialPos(current_song_name, numberOfNote, potencial_Q_note_pos.x, potencial_Q_note_pos.y, potencial_Q_note_pos.z);

            SaveBeatOfNote(current_song_name, numberOfNote, conductor.beatOfThisNote);

            Instantiate(cube, potencial_Q_note_pos, Quaternion.identity);

        }
         if (Input.GetKeyDown(KeyCode.W)){
            numberOfNote++;
            amountOfNote = numberOfNote;
            Vector3 potencial_W_note_pos = new Vector3(Wdetector.position.x, Wdetector.position.y, Wdetector.position.z);

            SaveNotePotencialPos(current_song_name, numberOfNote, potencial_W_note_pos.x, potencial_W_note_pos.y, potencial_W_note_pos.z);

            SaveBeatOfNote(current_song_name, numberOfNote, conductor.beatOfThisNote);

            Instantiate(cube, potencial_W_note_pos, Quaternion.identity);

        }
         if (Input.GetKeyDown(KeyCode.E)){
            numberOfNote++;
            amountOfNote = numberOfNote;
            Vector3 potencial_E_note_pos = new Vector3(Edetector.position.x, Edetector.position.y, Edetector.position.z);

            SaveNotePotencialPos(current_song_name, numberOfNote, potencial_E_note_pos.x, potencial_E_note_pos.y, potencial_E_note_pos.z);

            SaveBeatOfNote(current_song_name, numberOfNote, conductor.beatOfThisNote);

            Instantiate(cube, potencial_E_note_pos, Quaternion.identity);
 
        }
        
    }

    private void SaveNotePotencialPos(string music_name, int number, float x, float y, float z)
    {
        PlayerPrefs.SetFloat($"{music_name}_{number}_position_x", x);
        PlayerPrefs.SetFloat($"{music_name}_{number}_position_y", y);
        PlayerPrefs.SetFloat($"{music_name}_{number}_position_z", z);
        PlayerPrefs.Save();
    }
    private void SaveBeatOfNote(string music_name, int number,  float beatOfNote){
        PlayerPrefs.SetFloat($"{music_name}_{number}Q_beatOfNote", beatOfNote);
        PlayerPrefs.SetFloat($"{music_name}_{number}W_beatOfNote", beatOfNote);
        PlayerPrefs.SetFloat($"{music_name}_{number}E_beatOfNote", beatOfNote);
        PlayerPrefs.Save();
    }

    public  void SaveStage(){
        PlayerPrefs.SetInt($"{current_song_name}_AmountOfNotes", amountOfNote);
        PlayerPrefs.Save();
    }

    
    public void RecordstageAgain(){
        Refresh();
        SceneManager.LoadScene("MakeStage");       
    }


    private void Refresh(){
        for (int i = 1; i < amountOfNote ; i++){
            PlayerPrefs.DeleteKey($"{current_song_name}_{i}_position_x");
            PlayerPrefs.DeleteKey($"{current_song_name}_{i}_position_y"); 
            PlayerPrefs.DeleteKey($"{current_song_name}_{i}_position_z");
           
            PlayerPrefs.DeleteKey($"{current_song_name}_{i}Q_beatOfNote");
            PlayerPrefs.DeleteKey($"{current_song_name}_{i}W_beatOfNote");
            PlayerPrefs.DeleteKey($"{current_song_name}_{i}E_beatOfNote");
        }
        
        //PlayerPrefs.DeleteKey($"{music.clip.name}_{14}_position_x");
        //Debug.Log(PlayerPrefs.GetFloat($"{music.clip.name}_{i}_position_x"));
    }

    public void DeleteAll(){
        PlayerPrefs.DeleteAll();
        
    }
}
