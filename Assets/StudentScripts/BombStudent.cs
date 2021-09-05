using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombStudent : MonoBehaviour
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

            //Lection 6
            //Indsæt kode der destroyer all objekter i hits arrayed

            particleSystem.Play();
            Destroy(gameObject, particleSystem.main.duration);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, explosionSize);
    }
}
