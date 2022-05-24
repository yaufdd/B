using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMove : MonoBehaviour
{
    public Conductor conductor;
    public AudioClip[] songs;
    //public AudioClip[] clips;

    private Vector3 spawnPos;

    private string current_song_name;

   

    [SerializeField] private Vector3 removePos_Q, removePos_W, removePos_E;
    
    private char noteLastLetter;

    //public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        current_song_name = PlayerPrefs.GetString("song_name");
;
        spawnPos = transform.position;
        noteLastLetter = gameObject.name[gameObject.name.Length - 1];

        
        //for (int i = 0;i < clips.Length; i++)
        //{
        //    if (clips[i].name == PlayerPrefs.GetString)
        //}

        // Debug.Log($"{music.name}_{gameObject.name}_beatsOfNote");
        // Debug.Log(PlayerPrefs.GetFloat($"{music.name}_{gameObject.name}_beatsOfNote"));
    }

    private void Update() {
        if (SceneManager.GetActiveScene().name == "PlayScene")
        {
            if (noteLastLetter == 'W')
            {
                MoveWithMusic(removePos_W);
                
            }
            if (noteLastLetter == 'Q')
            {
                MoveWithMusic(removePos_Q);
                //Debug.Log($"{music.name}_{gameObject.name}_beatsOfNote");
            }
            if (noteLastLetter == 'E')
            {
                MoveWithMusic(removePos_E);
                //Debug.Log($"{music.name}_{gameObject.name}_beatsOfNote");
            }
            
        }
    }

    private void MoveWithMusic(Vector3 removePos)
    {
        transform.position =  Vector3.Lerp(
            spawnPos,
            removePos,
            (conductor.BeatsShownInAdvance - (PlayerPrefs.GetFloat($"{current_song_name}_{gameObject.name}_beatOfNote") - conductor.songPosInBeats)) / conductor.BeatsShownInAdvance);
    }
}
