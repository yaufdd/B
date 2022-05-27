using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float slideSpeed;
    
    public int points;

    private Animator animator;

    public Rigidbody rb;


    private void Start() {
        Cursor.visible = false;
        points = 0;

        transform.position = transform.position;
        slideSpeed = 0;

    }

    

    
    void FixedUpdate()
    {
        PlayerMovement();
 
    }

    private void PlayerMovement(){
        slideSpeed = 10;
        float direction = Input.GetAxis("Mouse X"); 
        rb.velocity = new Vector3(0, 0, slideSpeed *  -direction);
    }


    private void OnCollisionEnter(Collision other) {

        
        Destroy(other.gameObject);
        points ++;
        FindObjectOfType<AudioManager>().PlaySound("Slice");
        

        
     
    }

    
}
