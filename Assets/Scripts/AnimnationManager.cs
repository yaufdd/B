using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimnationManager : MonoBehaviour
{
    private Animator animator;

    public GameManager gameManager;

    public AudioManager audioManager;

    private void Start() {
        animator = GetComponent<Animator>();

    }
    
    private void FixedUpdate() {
        animator.SetBool("Slice", false);

        if (!audioManager.audioIsPlaying){
            if (gameManager.win){
                animator.SetBool("Win", true);
                Debug.Log("win");
            }
            else{
                animator.SetBool("Lose", true);
                Debug.Log("Lose");
            }
        }

        
    }

    private void OnCollisionEnter(Collision other) {
      
        animator.SetBool("Slice", true);
    }

    
}
