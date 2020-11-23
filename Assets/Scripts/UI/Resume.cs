using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject player;
    public void UnPause()
    {
        player.SetActive(true);
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
