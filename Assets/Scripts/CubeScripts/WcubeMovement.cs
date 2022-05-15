using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WcubeMovement : MonoBehaviour
{

    public Conductor conductor;
  
    private Vector3 startLerpingPosition;
    
    [SerializeField]
    private Vector3 endLerpingPosition;

    public WParameter noteW;

    private void Start() {

       
    }

    private void Update() {

        startLerpingPosition = transform.position;
 
        // if (SceneManager.GetActiveScene().name == "PlayScene"){
        //     MoveWithMusic(startLerpingPosition, endLerpingPosition);
        // }
    }


    public void MoveWithMusic(Vector3 SpawnPos, Vector3 RemovePos){
        transform.position = Vector3.Lerp(
            SpawnPos,
            RemovePos,
            (conductor.BeatsShownInAdvance - (noteW.w_beatOfThisNote- conductor.songPosInBeats)) / conductor.BeatsShownInAdvance

        );
    }
    
    
    



}
