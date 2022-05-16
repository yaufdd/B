using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveNotes : MonoBehaviour
{
    private int numberOfNote;
    public AudioSource music;

    public GameObject cube;

    public CubeParameter cubeParameter;

    public GameObject parentObject;

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
            Vector3 potencial_Q_note_pos = new Vector3(Qdetector.position.x + offsetX, Qdetector.position.y + 8f, Qdetector.position.z);
            SaveNotePosition($"{music.name}_{numberOfNote}", potencial_Q_note_pos.x, potencial_Q_note_pos.y, potencial_Q_note_pos.z);
            Instantiate(cube, potencial_Q_note_pos, Quaternion.identity);

        }
         if (Input.GetKeyDown(KeyCode.W)){
            numberOfNote++;
            Vector3 potencial_W_note_pos = new Vector3(Wdetector.position.x + offsetX, Wdetector.position.y + 8f, Wdetector.position.z);
            SaveNotePosition($"{music.name}_{numberOfNote}", potencial_W_note_pos.x, potencial_W_note_pos.y, potencial_W_note_pos.z);
            Instantiate(cube, potencial_W_note_pos, Quaternion.identity);

        }
         if (Input.GetKeyDown(KeyCode.E)){
            numberOfNote++;
            Vector3 potencial_E_note_pos = new Vector3(Edetector.position.x + offsetX, Edetector.position.y + 8f, Edetector.position.z);
            SaveNotePosition($"{music.name}_{numberOfNote}", potencial_E_note_pos.x, potencial_E_note_pos.y, potencial_E_note_pos.z);
            Instantiate(cube, potencial_E_note_pos, Quaternion.identity);

        }
        
    }

    private void SaveNotePosition(string note_info, float x, float y, float z)
    {
        PlayerPrefs.SetFloat($"{note_info}_x", x);
        PlayerPrefs.SetFloat($"{note_info}_y", y);
        PlayerPrefs.SetFloat($"{note_info}_z", z);
        PlayerPrefs.Save();
        Debug.Log($"{note_info}_x_y_z was saved successfully");
    }
}
