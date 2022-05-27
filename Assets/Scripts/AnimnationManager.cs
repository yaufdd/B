using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimnationManager : MonoBehaviour
{
    private Animator animator;

    public GameManager gameManager;

    public AudioManager audioManager;

    private int slice_count;

    private void Start() {
        animator = GetComponent<Animator>();

        slice_count = 1;

    }
    
    private void Update() {
        //animator.ResetTrigger("Slice");

        if (!audioManager.audioIsPlaying){
            if (gameManager.win){
                animator.SetBool("Win", true);
                Debug.Log(gameManager.win);
            }
            if (gameManager.lose){
                animator.SetBool("Lose", true);
                Debug.Log(gameManager.lose);
            }
           
        }

        

        
    }

    private void OnCollisionEnter(Collision other) {
        animator.SetTrigger("Slice");
    }

    

    
}
