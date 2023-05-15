using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiles : MonoBehaviour
{
    // variables
    public bool correctAnswer;
    public bool selected = false;
    public bool x = false;
    public Animator animator;

    void Start() {
        answerKeyManager.addToList(this);
    }

    void Update() {
        if(selected) {
            animator.Play("selected");
        } else if (x) {
            animator.Play("marked");
        } else {
            animator.Play("unmarked");
        }
            
    }
}
