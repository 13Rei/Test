using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    void Update()
    {
        
    }
    void OnMouseEnter()
    {
        Debug.Log("Q");
    }
    void OnMouseExit()
    {
        Debug.Log("t");
    }
    void OnMouseUp()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
