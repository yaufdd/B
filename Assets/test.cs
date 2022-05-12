using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
    //public AudioSource gameOnSong;

    [SerializeField]
    private int bpm;
    [SerializeField]
    private int BeatsShownInAdvance = 10;
    public Transform playerPos;

    public MusicManager musicManager;
  

    public float songPosition;
    public float songPosInBeats;
    public float secPerBeat;
    public float dsptimesong;

    public CubeParameters note;

    





    private void Start() {
        secPerBeat = 60f / bpm;

        dsptimesong = (float) AudioSettings.dspTime;
        //gameOnSong = GetComponent<AudioSource>();
       
          
        

    }

    private void Update() {
         songPosition = (float) (AudioSettings.dspTime - dsptimesong);
         songPosInBeats = songPosition / secPerBeat;
         
        if (musicManager.playSong){
            //gameOnSong.Play(); 
            MoveWithMusic(transform.position, playerPos.transform.position);
        }
        
            
    }

    public void MoveWithMusic(Vector3 SpawnPos, Vector3 RemovePos){
        transform.position = Vector3.Lerp(
            SpawnPos,
            RemovePos,
            (BeatsShownInAdvance - (note.beatOfThisNote - songPosInBeats)) / BeatsShownInAdvance

        );
    }
        
    
    



}
