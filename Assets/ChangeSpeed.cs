using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public void changeSpeed(float newSpeed)
    {
        PlayerPrefs.SetFloat("speed", newSpeed);
    }
}
