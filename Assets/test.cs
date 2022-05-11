using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
    public AudioSource song;
    public float songposition;
    public float songPosInBeats;
    public float secPerBeat;
    public float dsptimesong;
    public int bpm;
    public int cubeAmount;

    float[] notes;

    int nextIndex = 0;
    public float BeatsShownInAdvance;


    private void Start() {
        secPerBeat = 60f / bpm;

        dsptimesong = (float) AudioSettings.dspTime;

        song.Play();
        float[] notes = new float[cubeAmount];
        Debug.Log(notes.Length);
        

    }

    private void Update() {
        songposition = (float) (AudioSettings.dspTime - dsptimesong);

        songPosInBeats = songposition / secPerBeat;

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.E)){
            NotesPosition(songPosInBeats);
            nextIndex++;
        }
        
    }

    private void NotesPosition(float notePos){
        for (int i = 0; i < notes.Length; i++){
            notes[i] = notePos;
        }
    }



}
