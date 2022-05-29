using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    public int spawedCount;
    public int nextCubeNumber;


    private void Start() {
        spawedCount = 35;
        nextCubeNumber = 35;
        
    }

    private void OnCollisionEnter(Collision other) {
        
    }

    private void OnTriggerEnter(Collider other) {
        spawedCount--;

        nextCubeNumber++;

    }
}
