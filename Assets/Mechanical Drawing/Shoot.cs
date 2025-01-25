using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Range(0f, 1f)] public float t;

    // The start and end positions of the animation
    public Transform start;
    public Transform end;

    // The animation curve itself
    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Increase t by the time
        t += Time.deltaTime;

        // If time is greater than 1, set it back to 0
        if (t > 1)
        {
            t = 0;
        }
        // Move the object based on starting and ending positions, as well as an animation curve
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
