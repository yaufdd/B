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
        PlayerMovement();
    }

    private void PlayerMovement(){
        float direction = Input.GetAxis("Mouse X"); 
        rb.velocity = new Vector3(0, 0, slideSpeed *  -direction);
    }


    private void OnCollisionEnter(Collision other) {

        
             Destroy(other.gameObject);
        
       
    }
}
