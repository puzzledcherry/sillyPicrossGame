using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerKeyManager : MonoBehaviour
{
    // variables
    public tiles[] levelTiles;

    void Start() {
        // assuming levels are always 22 x 22 = 484 tiles in total
        levelTiles = new tiles[484];
    }

    // called once per frame
    void Update() {
        if (complete()) {
            Debug.Log("puzzled solved!!");
        }
    }

    bool complete() {
        for (int i = 0; i < levelTiles.Length; i++) {
            if (levelTiles[i].correctAnswer != levelTiles[i].selected) {
                return false;
            }
        }
        return true;
    }
}
