using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public PointManager pm;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Asteroid") {
            Destroy(collision.gameObject);
            pm.AddPoints(1);
        }
        Destroy(gameObject);
    }
}
