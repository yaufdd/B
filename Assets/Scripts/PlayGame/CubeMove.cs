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
    
    private char noteLastLetter;


    public GameObject cross;

    Animator animator;
    
    //public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        current_song_name = PlayerPrefs.GetString("song_name");
;
        spawnPos = transform.position;
        noteLastLetter = gameObject.name[gameObject.name.Length - 1];

        animator = GetComponent<Animator>();

        
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

    private void OnCollisionEnter(Collision other) {
        animator.SetBool("CubeSlice", true);
        Destroy(this, 0.5f);
    }

    private void MoveWithMusic(Vector3 removePos)
    {
        transform.position =  Vector3.Lerp(
            spawnPos,
            removePos,
            (conductor.BeatsShownInAdvance - (PlayerPrefs.GetFloat($"{current_song_name}_{gameObject.name}_beatOfNote") - conductor.songPosInBeats)) / conductor.BeatsShownInAdvance);
        if (transform.position.x == removePos.x){
            Debug.Log("hit");
            
            Destroy(transform.gameObject);
            Vector3 cross_spawn = new Vector3(removePos.x, removePos.y + 0.7f, removePos.z);
            GameObject cross_clone = (GameObject) Instantiate(cross, cross_spawn, Quaternion.Euler(30f, 90f, 45));
            FindObjectOfType<AudioManager>().PlaySound("Fail");
            Destroy(cross_clone, 0.25f);

           
        }
    }
}
