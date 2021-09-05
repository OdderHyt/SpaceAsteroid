using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Movement movement;
    public Rigidbody2D BulletPrefab;
    public float bulletSpeed = 2;
    private void Start() {
         movement = GetComponent<Movement>();
    }
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            movement.Forward();
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            movement.Backward();
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            movement.TurnRight();
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            movement.TurnLeft();
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Rigidbody2D newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
            Vector2 bulletVelocity = newBullet.transform.up * bulletSpeed;
            newBullet.AddForce(bulletVelocity, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Asteroid") {
            Destroy(gameObject);
        }
    }
}


