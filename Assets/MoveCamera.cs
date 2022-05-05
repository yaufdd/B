using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform followingObj;
   
    [SerializeField]
    private float offset;

    
    
    void Update()
    {
        transform.position = new Vector3(followingObj.position.x, followingObj.position.y + offset, followingObj.position.z);
    }
}
