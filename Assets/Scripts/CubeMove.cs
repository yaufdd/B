using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMove : MonoBehaviour
{
    public Conductor conductor;
    public AudioClip music;

    public Vector3 spawnPos;
    public Vector3 removePos;

    //public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
    }

    private void Update() {
        if (SceneManager.GetActiveScene().name == "PlayScene")
        {
            MoveWithMusic();
        }
    }

    private void MoveWithMusic()
    {
        transform.position =  Vector3.Lerp(
            spawnPos,
            removePos,
            (conductor.BeatsShownInAdvance - (PlayerPrefs.GetFloat($"{music.name}_{transform.name}_beatsOfNote") - conductor.songPosInBeats)) / conductor.BeatsShownInAdvance);
    }
}
