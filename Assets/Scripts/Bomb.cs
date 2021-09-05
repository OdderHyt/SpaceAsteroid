using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float TimeToBlow = 2.5f;
    public float explosionSize = 2f;
    public new ParticleSystem particleSystem;

    void Update()
    {
        TimeToBlow -= Time.deltaTime;
        if (TimeToBlow <= 0 && particleSystem.isStopped)
        {
            var hits = Physics2D.CircleCastAll(transform.position, explosionSize, Vector2.zero);

            foreach (var hit in hits)
            {
                var tag = hit.transform.tag;
                if (tag == "Asteroid" || tag == "Player")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
            particleSystem.Play();
            Destroy(gameObject, particleSystem.main.duration);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, explosionSize);
    }
}
