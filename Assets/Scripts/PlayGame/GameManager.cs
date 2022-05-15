using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject currentStage;


    [SerializeField]
    private Vector3 spawnPos;
    void Start()
    {
  
        
        GameObject stagePos = Instantiate(currentStage, spawnPos, Quaternion.identity);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
