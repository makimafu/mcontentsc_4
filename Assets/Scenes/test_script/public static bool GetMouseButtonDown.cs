using UnityEngine;
using System.Collections;

// Detects clicks from the mouse and prints a message
// depending on the click detected.

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left-click.");

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right-click.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle-click.");
    }
}