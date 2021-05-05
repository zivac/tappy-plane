using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    float speed = 0f;

    [SerializeField]
    float acceleration = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSpeed();
        Move();
        //transform.position = new Vector2(transform.position.x, 0);
    }

    private void UpdateSpeed()
    {
        acceleration = Input.GetMouseButton(0) ? 10 : -10;
        speed += acceleration * Time.deltaTime;
    }

    private void Move()
    {
        var deltaY = Time.deltaTime * speed;
        transform.position = new Vector2(transform.position.x, transform.position.y + deltaY);
    }
}
