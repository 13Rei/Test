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
        if (child.name == "Cube" || child.name == "Arrow" || child.name == "Triangle")
        {
            Vector3 deltaPosition = transform.position - prevPosition;

            deltaPosition.Normalize();

            if (deltaPosition != Vector3.zero)
            {
                float angle = Mathf.Atan2(deltaPosition.z, deltaPosition.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, angle);
            }
            prevPosition = transform.position;
        }
        else if(child.name == "DVD")
        {
            transform.rotation = Quaternion.Euler(90, 180, 0);
        }
        else if(child.name == "shuriken")
        {
            child.transform.Rotate(0, 0, -300f * Time.deltaTime);
        }
    }
}
