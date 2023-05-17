using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class answerKeyManager : MonoBehaviour
{
    // variables
    tiles currSelect;
    public static List<tiles> tileBoard = new List<tiles>();

    void Start() {

    }

    // called once per frame
    void Update() {
        // check if the user clicked a tile
        userClick();
        if (complete()) {
            Debug.Log("puzzle solved!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    bool complete() {
        for (int i = 0; i < tileBoard.Count; i++) {
            if (tileBoard[i].selected != tileBoard[i].correctAnswer) {
                return false;
            }
        }
        return true;
    }

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

    // get the tile the user clicked
    void getObject() {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider.gameObject.tag == "tiles") {
                currSelect = hit.collider.gameObject.GetComponent<tiles>();
        }
    }

    public static void addToList(tiles t) {
        tileBoard.Add(t);
    }

}
