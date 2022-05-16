using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public Conductor conductor;
    public AudioClip music;

    public Vector3 removePos;

    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update() {
        for (int i = 0;i < gameManager.notes.Count; i++){
            Vector3 spawnPos = new Vector3(PlayerPrefs.GetFloat($"{music.name}_{i}_position_x"),
                                            PlayerPrefs.GetFloat($"{music.name}_{i}_position_y"),
                                            PlayerPrefs.GetFloat($"{music.name}_{i}_position_z"));
            gameManager.notes[i].transform.position = Vector3.Lerp(spawnPos, 
            removePos, 
            (conductor.BeatsShownInAdvance - (PlayerPrefs.GetFloat($"{music.name}_{i}") - conductor.songPosInBeats)) / conductor.BeatsShownInAdvance);
        }
    }

    // private void MoveWithMusic(Vector3 spawnPos, Vector3 removePos, int numberOfNote){
    //     transform.position = Vector3.Lerp(
    //     spawnPos,
    //     removePos,
    //     (conductor.BeatsShownInAdvance - (PlayerPrefs.GetFloat($"{music.name}_{numberOfNote}") - conductor.songPosInBeats)) / conductor.BeatsShownInAdvance
    // );    
    // }
}
