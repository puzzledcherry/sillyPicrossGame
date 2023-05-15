using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerKeyManager : MonoBehaviour
{
    // variables
    private tiles[] levelTiles;
    tiles currSelect;

    void Start() {
        // assuming levels are always 22 x 22 = 484 tiles in total
        levelTiles = new tiles[484];
    }

    // called once per frame
    void Update() {
        // check if the user clicked a tile
        userClick();

        // check if the puzzle is completed
        /* if (complete()) {
            Debug.Log("puzzled solved!!");
        } */
    }

    // check if the puzzle is completed
    /* bool complete() {
        // for every tile in the puzzle check the answer is correct
        for (int i = 0; i < levelTiles.Length; i++) {
            // if one tile doesn't match, not complete return false
            if (levelTiles[i].correctAnswer != levelTiles[i].selected) {
                return false;
            }
        }

        // all tiles match their answer key, return true
        return true;
    } */

    // when a user clicks something
    void userClick() {
        // if it's a left click, select the tile    
        if (Input.GetMouseButtonDown(0)) {
            getObject();
            currSelect.selected = !(currSelect.selected);
            currSelect.x = false;
        }

        // if it's a right click, x the tile out
        if (Input.GetMouseButtonDown(1)) {
            getObject();
            currSelect.x = !(currSelect.x);
            currSelect.selected = false;
        }

    }

    void getObject() {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider.gameObject.tag == "tiles") {
                currSelect = hit.collider.gameObject.GetComponent<tiles>();
        }
    }

}
