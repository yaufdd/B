using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    
    public int bpm;
    
    public int BeatsShownInAdvance;

    public float songPosition;
    public float songPosInBeats;
    public float secPerBeat;
    public float dsptimesong;
    public float beatOfThisNote;

    public float current_song_pos;

    void Start()
    {
        bpm = PlayerPrefs.GetInt("current_bpm");
        BeatsShownInAdvance = 35;

        Debug.Log($"{bpm} = bpm");

        secPerBeat = 60f / bpm;

        dsptimesong = (float) AudioSettings.dspTime;
    }

    void Update()
    {
        current_song_pos = (float)AudioSettings.dspTime;
        songPosition = (float) (AudioSettings.dspTime - dsptimesong);
        songPosInBeats = songPosition / secPerBeat;
        beatOfThisNote = songPosInBeats;
    }
}
