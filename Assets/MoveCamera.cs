using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Quaternion startQuaternion;

    public Transform detectorPos;
    public Transform playerPos;

    public MusicManager musicManager;
   
    [SerializeField]
    private float offsetY, offsetX;
    [SerializeField]
    private float rotationOffset;

    private bool wannaMakeLvl = true;

    //public AudioSource song;

    public Vector3 followPlayerPos;
    public Vector3 followplayerRot;
    
    

    private void Start() {
        startQuaternion = transform.rotation;
        
        //song.Play();
    }

    
    
    void Update()
    {
        if (wannaMakeLvl){
            transform.position = new Vector3(detectorPos.position.x + offsetX, detectorPos.position.y + offsetY, detectorPos.position.z);
            transform.rotation = Quaternion.Euler(90, 90, 0);
        }
        if (musicManager.playSong){
            wannaMakeLvl = false;
           // song.Stop();
            
            
        }  
        if (!wannaMakeLvl){
            offsetX = 10;
            transform.position =  new Vector3(playerPos.position.x + (-13), playerPos.position.y + 10   , playerPos.position.z);
            transform.rotation = Quaternion.Euler(followplayerRot);
            
            
            
        }
    }


    
}
