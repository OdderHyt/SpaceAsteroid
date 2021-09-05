using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Asteroid") {
            Destroy(collision.gameObject);
            PointManagerStudent.Instance.AddPoints(1);
        }
        Destroy(gameObject);
    }
}
