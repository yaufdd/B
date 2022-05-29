using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CubeMove : MonoBehaviour
{
    public Conductor conductor;

    private Vector3 spawnPos;

    private string current_song_name;

    public bool pointFail;
   
    [SerializeField] private Vector3 removePos_Q, removePos_W, removePos_E;

    [SerializeField] private float beatOfThisNote;
    
    private char noteLastLetter;

    public GameObject cross;

    Animator animator;

    [SerializeField]
    private float  dspTimeWithOutLag;
    private float secPerBeatWithOutLag;
    
    void Start()
    {
        current_song_name = PlayerPrefs.GetString("song_name");
;
        spawnPos = transform.position;
        noteLastLetter = gameObject.name[gameObject.name.Length - 1];

        animator = GetComponent<Animator>();



        dspTimeWithOutLag = PlayerPrefs.GetFloat("dsptime");
        secPerBeatWithOutLag = 60f / PlayerPrefs.GetInt("current_bpm") ;

    }

    private void Update() {
        if (SceneManager.GetActiveScene().name == "PlayScene")
        {
            float songPosWithOutLag =  (float)(AudioSettings.dspTime - dspTimeWithOutLag);
            float songPosInBeatsWithOutLag = songPosWithOutLag /secPerBeatWithOutLag;
            if (noteLastLetter == 'W')
            {
                MoveWithMusic(removePos_W, songPosInBeatsWithOutLag);               
            }
            if (noteLastLetter == 'Q')
            {
                MoveWithMusic(removePos_Q, songPosInBeatsWithOutLag);
            }
            if (noteLastLetter == 'E')
            {
                MoveWithMusic(removePos_E, songPosInBeatsWithOutLag);
            }           
        }      
    }

    private void MoveWithMusic(Vector3 removePos, float songPosInBeats_parameter)
    {
        


        transform.position =  Vector3.Lerp(
            spawnPos,
            removePos,
            (conductor.BeatsShownInAdvance - (PlayerPrefs.GetFloat($"{current_song_name}_{gameObject.name}_beatOfNote") - songPosInBeats_parameter)) / conductor.BeatsShownInAdvance);
        if (transform.position.x == removePos.x){

            Destroy(transform.gameObject);
            Vector3 cross_spawn = new Vector3(removePos.x, removePos.y + 0.7f, removePos.z);
            GameObject cross_clone = (GameObject) Instantiate(cross, cross_spawn, Quaternion.Euler(30f, 90f, 45));
            FindObjectOfType<AudioManager>().PlaySound("Fail");
            Destroy(cross_clone, 0.25f);
        }
    }
}
