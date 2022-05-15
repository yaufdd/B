using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    [SerializeField]
    private int bpm;
    
    public int BeatsShownInAdvance = 10;


    private Vector3 startLerpingPosition;
    
    [SerializeField]
    private Vector3 endLerpingPosition;

    
    public float songPosition;
    public float songPosInBeats;
    public float secPerBeat;
    public float dsptimesong;
    // Start is called before the first frame update
    void Start()
    {
        startLerpingPosition = transform.position;

        secPerBeat = 60f / bpm;

        dsptimesong = (float) AudioSettings.dspTime;
    }

    // Update is called once per frame
    void Update()
    {
        songPosition = (float) (AudioSettings.dspTime - dsptimesong);
        songPosInBeats = songPosition / secPerBeat;
    }
}
