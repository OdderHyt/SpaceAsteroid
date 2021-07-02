using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float MovementSpeed = 5, TurningSpeed = 20;


    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Forward() {
        rb.velocity += (Vector2)transform.up * Time.deltaTime * MovementSpeed;
    }

    public void Backward() {
        rb.velocity -= (Vector2)transform.up * Time.deltaTime * MovementSpeed;
    }

    public void TurnLeft() {
        transform.Rotate(0f,0f,  TurningSpeed * Time.deltaTime);
    }

    public void TurnRight() {
        transform.Rotate(0f,0f, -TurningSpeed * Time.deltaTime);

    }
}
