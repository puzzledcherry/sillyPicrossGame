using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        
            if (hit.collider.gameObject.tag == "buttonOne") {
                    Debug.Log("clicked level 1");
                    SceneManager.LoadScene("levelOne");
            }

            if (hit.collider.gameObject.tag == "buttonTwo") {
                    SceneManager.LoadScene("levelTwo");
            }
            
            if (hit.collider.gameObject.tag == "buttonThree") {
                    SceneManager.LoadScene("levelThree");
            }
        }
    }
}
