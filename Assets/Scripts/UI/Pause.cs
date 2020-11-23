using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject player;
    void OnMouseUp()
    {
        player.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}