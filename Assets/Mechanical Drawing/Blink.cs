using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1f)] public float t;
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
            // Increase t by the time
            t += Time.deltaTime;

            // If t is greater than 1, set it back to zero
            if (t > 1)
            {
                t = 0;
            }
            // Transform the scale of the object based off an animation curve
            transform.localScale = Vector2.one * curve.Evaluate(t);
        }
    }
}
