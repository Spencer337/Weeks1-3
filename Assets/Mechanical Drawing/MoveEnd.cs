using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnd : MonoBehaviour
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

            // Move the end point to a new position between (7, -4) and (9, -2)
            Vector3 pos = new Vector3(0, 0, 0);
            pos.x = Random.Range(7f, 9f);
            pos.y = Random.Range(-4f, -2f);
            transform.position = pos;
        }
    }
}
