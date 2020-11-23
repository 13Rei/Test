using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marketplace : MonoBehaviour
{
    public GameObject cam;
    void OnMouseUp()
    {
        cam.transform.position = new Vector3(-37f, cam.transform.position.y, cam.transform.position.z);
    }
}
