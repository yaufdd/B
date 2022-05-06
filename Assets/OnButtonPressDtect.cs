using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonPressDtect : MonoBehaviour
{
    private bool isPressed;
    public GameObject cude;
    public Transform Qdetector;
    public Transform Wdetector;
    public Transform Edetector;

    [SerializeField] private float offsetX, offsetY;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)){
            Debug.Log($" Q position {Qdetector.position}");
            Instantiate(cude, new Vector3(Qdetector.position.x + offsetX, Qdetector.position.y + 8f, Qdetector.position.z), Quaternion.identity);
        }
         if (Input.GetKeyDown(KeyCode.W)){
            Debug.Log($" W position {Wdetector.position}");
            Instantiate(cude, new Vector3(Wdetector.position.x, Wdetector.position.y + 8f, Wdetector.position.z), Quaternion.identity);
        }
         if (Input.GetKeyDown(KeyCode.E)){
            Debug.Log($" E position {Edetector.position}");
            Instantiate(cude, new Vector3(Edetector.position.x, Edetector.position.y + 8f, Edetector.position.z), Quaternion.identity);
        }
        
    }
}
