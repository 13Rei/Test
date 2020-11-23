using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetThings : MonoBehaviour
{
    public GameObject place;
    public GameObject cam;
    public Slider slider;
    void OnMouseDown()
    {
        place.SetActive(true);
        cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, 22f);
        slider.value = PlayerPrefs.GetFloat("speed");
    }
        
}
