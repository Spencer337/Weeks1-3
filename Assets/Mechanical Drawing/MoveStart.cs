using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveStart : MonoBehaviour
{
    // A float to keep track of the time
    public float time = 0.0f;
    // The interval between each movement
    public float wait = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Increase time variable 
        time += Time.deltaTime;
        // If time is greater than the interval
        if (time >= wait)
        {
            // Set time to 0
            time = 0.0f;

            // Move the start point to a new position between (-8, 2) and (-6, 4)
            Vector3 pos = new Vector3(0, 0, 0);
            pos.x = Random.Range(-8f, -6f);
            pos.y = Random.Range(2f, 4f);
            transform.position = pos;
        }
        
    }
}
