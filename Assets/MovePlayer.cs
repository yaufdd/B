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

    private Vector3 startPosition;


    public Rigidbody rb;
    private void Start() {
        startPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)){
            go = true;
            //transform.position = startPosition;
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


    private void OnCollisionEnter(Collision other) {

        if (other.gameObject.tag == "points"){
             Destroy(other.gameObject);
        }
       
    }
}
