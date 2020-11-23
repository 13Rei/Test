using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
public class script : MonoBehaviour
{
    bool isStart;
    public Rigidbody player;
    public Camera cam;
    public LineRenderer line;
    public Slider slider;
    Vector3 pos;
    Vector3 dir;
    [Tooltip("Moving object force")]
    [Space]
    public float force;
    public Vector3 diff;
    Vector3 prevpos;


    void Start()
    {
        force = 5f;
        isStart = true;
        line.enabled = false;
    }
    void Update()
    {
        pos = cam.WorldToScreenPoint(transform.position);
        #region Moven
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Debug.Log("Mouse down " + isStart);
            if (isStart) { 
                line.enabled = true;
            }
        }
        if (Input.GetMouseButtonUp(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            Debug.Log("Mouse Up");
            if (isStart)
            {
                dir = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
                player.velocity = new Vector3(dir.x, 0.0f, dir.z) * force;
                line.enabled = false;
                isStart = false;
            }
        }
        #endregion
    }
    void FixedUpdate()
    {
        #region Rotation
        if (Input.GetMouseButton(0))
        {
            Vector3 dir = Input.mousePosition - pos;
            float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(90, angle + 180, 0);
        }
        #endregion
        else
        {
            Vector3 delta = transform.position - prevpos;

            if (delta != Vector3.zero)
            {
                float Angle = Mathf.Atan2(delta.x, delta.z) * Mathf.Rad2Deg;

                transform.rotation = Quaternion.Euler(90, Angle, 0);
            }
            prevpos = transform.position;
        }
    }

    public void ChangeSpeed(float newSpeed)
    {
        newSpeed = 10f;
    }
}