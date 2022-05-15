using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EcubeMovement : MonoBehaviour
{

    [SerializeField]
    private int bpm;
    [SerializeField]
    private int BeatsShownInAdvance = 10;
  
    private Vector3 startLerpingPosition;
    
    [SerializeField]
    private Vector3 endLerpingPosition;


    public float songPosition;
    public float songPosInBeats;
    public float secPerBeat;
    public float dsptimesong;

    public EParameter noteE;

    private void Start() {

        startLerpingPosition = transform.position;

        secPerBeat = 60f / bpm;

        dsptimesong = (float) AudioSettings.dspTime;
    }

    private void Update() {
         songPosition = (float) (AudioSettings.dspTime - dsptimesong);
         songPosInBeats = songPosition / secPerBeat;
  
        if (SceneManager.GetActiveScene().name == "PlayScene"){
            MoveWithMusicE(startLerpingPosition, endLerpingPosition);
         
        }
    }

    private void MoveWithMusicE(Vector3 SpawnPos, Vector3 RemovePos){
        transform.position = Vector3.Lerp(
            SpawnPos,
            RemovePos,
            (BeatsShownInAdvance - (noteE.e_beatOfThisNote - songPosInBeats)) / BeatsShownInAdvance

        );
    }
    
    
    



}
