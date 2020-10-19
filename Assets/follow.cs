using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject parent;
    public GameObject child;

    public Vector3 prevPosition;

    void Start()
    {
        prevPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = parent.transform.position;
        if (child.name != "Cube" && child.name != "Arrow" && child.name != "Triangle")
        {
            transform.rotation = Quaternion.Euler(90, 180, 0);
        }
        else
        {
            Vector3 deltaPosition = transform.position - prevPosition;

            if (deltaPosition != Vector3.zero)
            {
                // Same effect as rotating with quaternions, but simpler to read
                transform.forward = deltaPosition;
            }
            // Recording current position as previous position for next frame
            prevPosition = transform.position;
        }
    }
}
