using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform detectorPos;
    public Transform playerPos;
   
    [SerializeField]
    private float offsetY, offsetX;
    [SerializeField]
    private float rotationOffset;

    private bool wannaMakeLvl = true;

    //public Quaternion q;

    
    
    void Update()
    {
        if (wannaMakeLvl){
            transform.position = new Vector3(detectorPos.position.x + offsetX, detectorPos.position.y + offsetY, detectorPos.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Return)){
            wannaMakeLvl = false;
        }  
        if (!wannaMakeLvl){
            offsetX = 10;
            transform.position =  new Vector3(playerPos.position.x + offsetX, playerPos.position.y + offsetY, playerPos.position.z);
            //transform.rotation = q;
            
            
        }
    }
}
