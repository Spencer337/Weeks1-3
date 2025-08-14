using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoon : MonoBehaviour
{
    public float speed = 0.05f;
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z -= speed + Time.deltaTime;
        transform.eulerAngles = rot;
    }
}
