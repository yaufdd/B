using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonPressDtect : MonoBehaviour
{
    private bool isPressed;
    public GameObject cude;

    public CubeParameters cubeParameter;

    public GameObject parentObject;

    public test songPosInBeats;
    public Transform Qdetector;
    public Transform Wdetector;
    public Transform Edetector;

    private GameObject newCube;


    [SerializeField] private float offsetX, offsetY;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)){
            newCube = Instantiate(cude, new Vector3(Qdetector.position.x + offsetX, Qdetector.position.y + 8f, Qdetector.position.z), Quaternion.identity);
            newCube.transform.parent = parentObject.transform;
            cubeParameter.beatOfThisNote = songPosInBeats.songPosInBeats;

            // Debug.Log($"position of song in beats {songPosInBeats.songPosInBeats}");
            // Debug.Log($"position of cube in beat{cubeParameter.beatOfThisNote}");
        }
         if (Input.GetKeyDown(KeyCode.W)){
            newCube = Instantiate(cude, new Vector3(Wdetector.position.x + offsetX, Wdetector.position.y + 8f, Wdetector.position.z), Quaternion.identity);
            newCube.transform.parent = parentObject.transform;
            cubeParameter.beatOfThisNote = songPosInBeats.songPosInBeats;
        }
         if (Input.GetKeyDown(KeyCode.E)){
            newCube = Instantiate(cude, new Vector3(Edetector.position.x + offsetX, Edetector.position.y + 8f, Edetector.position.z), Quaternion.identity);
            newCube.transform.parent = parentObject.transform;
            cubeParameter.beatOfThisNote = songPosInBeats.songPosInBeats;
        }
        
    }
}
