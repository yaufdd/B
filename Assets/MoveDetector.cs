using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDetector : MonoBehaviour
{
    [SerializeField]
    private float speed;
    

   
    void Update()
    {
        transform.Translate(new Vector3(speed, 0, 0) *  Time.deltaTime);
    }
}
