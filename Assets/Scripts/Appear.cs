using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.y >= 0)
        {
            pos.z = 0;
        }
        else
        {
            pos.z = -10;
        }
        transform.position = pos;
    }
}
