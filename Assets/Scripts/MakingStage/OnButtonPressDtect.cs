using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonPressDtect : MonoBehaviour
{

    public GameObject cube;

    public Conductor conductor;
    public CubeParameter cubeParameter;

    public GameObject parentObject;

    public Transform Qdetector;
    public Transform Wdetector;
    public Transform Edetector;

    private GameObject newCubeQ;
    private GameObject newCubeW;
    private GameObject newCubeE;



    [SerializeField] private float offsetX, offsetY;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)){
            newCubeQ = Instantiate(cube, new Vector3(Qdetector.position.x + offsetX, Qdetector.position.y + 8f, Qdetector.position.z), Quaternion.identity);
            newCubeQ.name = "Q";
            newCubeQ.transform.parent = parentObject.transform;
            cubeParameter.beatsOfThisNote = conductor.songPosInBeats;
            
        }
         if (Input.GetKeyDown(KeyCode.W)){
            newCubeW = Instantiate(cube, new Vector3(Wdetector.position.x + offsetX, Wdetector.position.y + 8f, Wdetector.position.z), Quaternion.identity);
            newCubeW.name = "W";
            newCubeW.transform.parent = parentObject.transform;
            cubeParameter.beatsOfThisNote = conductor.songPosInBeats;
        }
         if (Input.GetKeyDown(KeyCode.E)){
            newCubeE = Instantiate(cube, new Vector3(Edetector.position.x + offsetX, Edetector.position.y + 8f, Edetector.position.z), Quaternion.identity);
            newCubeE.name = "E";
            newCubeE.transform.parent = parentObject.transform;
            cubeParameter.beatsOfThisNote = conductor.songPosInBeats;
        }
        
    }
}
