using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void OnMouseUp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
