using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveAndFlip : MonoBehaviour
{
    public float speed = 5f;
    public float t;
    public AnimationCurve curve;
    public AnimationCurve trick;
    public bool jumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        Vector3 rot = transform.eulerAngles;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        if (screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }

        transform.position = pos;


        if (jumping)
        {
            t += Time.deltaTime;

            if (t > 1)
            {
                t = 0;
                jumping = false;
            }
            pos.y = curve.Evaluate(t);
            transform.position = pos;
            rot.z = trick.Evaluate(t);
            transform.eulerAngles = rot;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
            
        }
    }
}
