using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check for input (touch or mouse click)
        if (Input.GetMouseButtonDown(0)) // 0 represents left mouse button, change if needed
        {
            // Load the "Game" scene
            SceneManager.LoadScene("Game");
        }
    }
}
