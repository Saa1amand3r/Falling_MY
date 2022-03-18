using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_v2 : MonoBehaviour
{
    private float direction;
    public float speed = 10f;
    public float speed_y = 10f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android) {
            direction = Input.acceleration.x;
        } else {
            direction = Input.GetAxis ("Horizontal");
        }
        direction *= Time.deltaTime;

        transform.Translate (direction * speed,speed_y,0);

    }
    
}
