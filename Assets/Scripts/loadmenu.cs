using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadmenu : MonoBehaviour
{
    void OnMouseUp()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
