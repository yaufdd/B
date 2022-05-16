using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    [SerializeField]
    private int bpm;
    
    public int BeatsShownInAdvance = 10;

    public float songPosition;
    public float songPosInBeats;
    public float secPerBeat;
    public float dsptimesong;

    void Start()
    {

        secPerBeat = 60f / bpm;

        dsptimesong = (float) AudioSettings.dspTime;
    }

    void Update()
    {
        songPosition = (float) (AudioSettings.dspTime - dsptimesong);
        songPosInBeats = songPosition / secPerBeat;
    }
}
