using UnityEngine;
public class script : MonoBehaviour
{
    bool isStart;
    public Rigidbody player;
    public Camera cam;
    public LineRenderer line;
    Vector3 pos;
    [Tooltip("Moving object force")]
    [Space]
    public float force = 220000f;


    void Start()
    {
        isStart = true;
        line.enabled = false;
    }
    void Update()
    {
        pos = cam.WorldToScreenPoint(transform.position);
        #region Moven
        if (Input.GetMouseButtonDown(1) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            if (isStart)
                line.enabled = true;
        }
        if (Input.GetMouseButtonUp(1) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            if (isStart)
            {
                player.AddForce((transform.forward * force * Time.deltaTime)*-1);
                line.enabled = false;
                isStart = false;
            }
        }
        #endregion
    }
    void FixedUpdate()
    {
        #region Rotation
        if (Input.GetMouseButton(1))
        {
            Vector3 dir = Input.mousePosition - pos;
            float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, angle, 0);
        }
        #endregion
    }
}