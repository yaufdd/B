using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLerp : MonoBehaviour
{
    public Vector3 SpawnPos;
    public Transform RemovePos;

    public float t;

    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z),
        new Vector3(RemovePos.position.x, RemovePos.position.y, RemovePos.position.z), t);
    }
}
