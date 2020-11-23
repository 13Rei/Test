using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update

    void OnMouseUp()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
