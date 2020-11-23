using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject cam;
    void OnMouseUp()
    {
        cam.transform.position = new Vector3(0f, cam.transform.position.y, cam.transform.position.z);
    }
}
