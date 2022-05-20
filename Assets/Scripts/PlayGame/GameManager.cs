using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool pause;

    private void Start() {
        pause = false;
    }
    private void Update() {
        if (Input.GetKey(KeyCode.Escape)){
            pause = !pause;   
        }
        if (!pause){
            Time.timeScale = 1;
        }
        else{
            Time.timeScale = 0;
        }
    }
    
}
