using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float slideSpeed;
    


    public Rigidbody rb;
    private void Start() {
        Cursor.visible = false;
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
