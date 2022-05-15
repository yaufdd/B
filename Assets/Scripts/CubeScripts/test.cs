using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour
{
    //public AudioSource gameOnSong;

    [SerializeField]
    private int bpm;
    [SerializeField]
    private int BeatsShownInAdvance = 10;

    //public MusicManager musicManager;

    
    private Vector3 startLerpingPosition;
    
    [SerializeField]
    private Vector3 endLerpingPosition;

    


  

    public float songPosition;
    public float songPosInBeats;
    public float secPerBeat;
    public float dsptimesong;

    public QParameter noteQ;

  
    

    





    private void Start() {

        


        startLerpingPosition = transform.position;

        secPerBeat = 60f / bpm;

        dsptimesong = (float) AudioSettings.dspTime;
        //gameOnSong = GetComponent<AudioSource>();
       
          
        

    }

    private void Update() {
         songPosition = (float) (AudioSettings.dspTime - dsptimesong);
         songPosInBeats = songPosition / secPerBeat;

        if (SceneManager.GetActiveScene().name == "PlayScene"){
            MoveWithMusicQ(startLerpingPosition, endLerpingPosition);
        }
        
        
            
    }

    public void MoveWithMusicQ(Vector3 SpawnPos, Vector3 RemovePos){
        transform.position = Vector3.Lerp(
            SpawnPos,
            RemovePos,
            (BeatsShownInAdvance - (noteQ.q_beatOfThisNote - songPosInBeats)) / BeatsShownInAdvance

        );
    }
    
    
    



}
