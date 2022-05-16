using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMove : MonoBehaviour
{


    public Conductor conductor;
    public CubeParameter cubeParameter;

    private Vector3 startLerp;

    public Transform q_endLerp;
    public Transform w_endLerp;
    public Transform e_endLerp;

    private float koef;

    void Start()
    {
        startLerp = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        koef = ((conductor.BeatsShownInAdvance - (cubeParameter.beatsOfThisNote - conductor.songPosInBeats)) / conductor.BeatsShownInAdvance);
        Debug.Log($"{koef} = {conductor.BeatsShownInAdvance} - ({cubeParameter.beatsOfThisNote} - {conductor.songPosInBeats}) / {conductor.BeatsShownInAdvance}");

        if (SceneManager.GetActiveScene().name == "PlayScene")
        {
            if (gameObject.name == "Q")
            {
                MoveWithMusic(startLerp, q_endLerp.position, cubeParameter, "q");

            }
            if (gameObject.name == "W")
            {
                MoveWithMusic(startLerp, w_endLerp.position, cubeParameter, "w");

            }
            if (gameObject.name == "E")
            {
                MoveWithMusic(startLerp, e_endLerp.position, cubeParameter, "e");
               

            }

        }
        
        
    }

    public void MoveWithMusic(Vector3 spawnPos, Vector3 removePos, CubeParameter current_cube, string letter)
    {
         transform.position = Vector3.Lerp(
         spawnPos,
         removePos,
         (conductor.BeatsShownInAdvance - (current_cube.beatsOfThisNote - conductor.songPosInBeats)) / conductor.BeatsShownInAdvance);
         Debug.Log(letter);
        
    }
}
