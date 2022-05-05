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

        float slideSpeed = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(playerSpeed, 0, slideSpeed) * Time.deltaTime);
        
        

    }
}
