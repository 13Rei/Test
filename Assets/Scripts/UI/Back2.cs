using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Back2 : MonoBehaviour
{
    public GameObject cam;
    public GameObject place;
    public Slider slider;

    void OnMouseDown()
    {
        cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, 0f);
        place.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        slider.value = PlayerPrefs.GetFloat("speed");
    }
}
