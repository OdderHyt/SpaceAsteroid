using UnityEngine;

public class SpawnerStudent : MonoBehaviour
{
    public Rigidbody2D Prefab;
    public Vector2 SpawnPosition = Vector2.zero;

    private void Start()
    {

        //Lection 4
        //Eksemple på hvordan man kna instantiate et game object
        Rigidbody2D newAsteroid = Instantiate(Prefab, SpawnPosition, Quaternion.identity);

    }

    private void Update()
    {
        //Brug instatiation og conditionals til at lave en timer der periodisk laver nye asteroider.
        //Kan du komme på andre conditions for at lave nye asteroider?
    }
}
