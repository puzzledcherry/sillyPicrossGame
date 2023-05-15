using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiles : MonoBehaviour
{
    // variables
    public bool correctAnswer;
    public bool selected = false;
    public bool x = false;

    void Start() {
        answerKeyManager.addToList(this);
    }
}
