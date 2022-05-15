using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonPressDtect : MonoBehaviour
{
    private bool isPressed;
    public GameObject cubeQ;
    public GameObject cubeW;
    public GameObject cubeE;
    

    public Conductor conductor;
    public QParameter cubeParameterQ;
    public WParameter cubeParameterW;
    public EParameter cubeParameterE;

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
            newCubeQ = Instantiate(cubeQ, new Vector3(Qdetector.position.x + offsetX, Qdetector.position.y + 8f, Qdetector.position.z), Quaternion.identity);
            newCubeQ.transform.parent = parentObject.transform;
            cubeParameterQ.q_beatOfThisNote = conductor.songPosInBeats;
        }
         if (Input.GetKeyDown(KeyCode.W)){
            newCubeW = Instantiate(cubeW, new Vector3(Wdetector.position.x + offsetX, Wdetector.position.y + 8f, Wdetector.position.z), Quaternion.identity);
            newCubeW.transform.parent = parentObject.transform;
            cubeParameterW.w_beatOfThisNote = conductor.songPosInBeats;
        }
         if (Input.GetKeyDown(KeyCode.E)){
            newCubeE = Instantiate(cubeE, new Vector3(Edetector.position.x + offsetX, Edetector.position.y + 8f, Edetector.position.z), Quaternion.identity);
            newCubeE.transform.parent = parentObject.transform;
            cubeParameterE.e_beatOfThisNote =  conductor.songPosInBeats;
        }
        
    }
}
