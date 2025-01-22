using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 position = transform.position;

        //position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //transform.position = position;

        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
    }
}
