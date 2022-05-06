using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float slideSpeed;
    private bool go;


    public Rigidbody rb;

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            go = true;
        }
        if (go){
            PlayerMovement();
            Debug.Log(slideSpeed);
        }
    }

    private void PlayerMovement(){
        float direction = Input.GetAxis("Mouse X"); 
        rb.velocity = new Vector3(playerSpeed, 0, slideSpeed *  -direction);
    }
}
