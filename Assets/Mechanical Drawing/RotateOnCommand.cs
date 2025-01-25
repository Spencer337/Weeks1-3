using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnCommand : MonoBehaviour
{
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the horizontal direction keys are pressed
        if (Input.GetAxis("Horizontal") != 0)
        {
            // Rotate the object based on the given speed variable
            Vector3 rot = transform.eulerAngles;
            rot.z -= speed + Time.deltaTime;
            transform.eulerAngles = rot;
        }
    }
}
