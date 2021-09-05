using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody2D Prefab;
    public Vector2 SpawnPosition = Vector2.zero;
    public float AsteroidSpeed = 1;
    private float timeLeft = 10;

    private void Start()
    {
        Rigidbody2D newAsteroid = Instantiate(Prefab, SpawnPosition, Quaternion.identity);

        newAsteroid.transform.Rotate(0f, 0f, Random.Range(0f, 360f));


        //AsteroidSpeed = Random.Range(1, 10);
        Vector2 AsteroidVelocity = newAsteroid.transform.up * AsteroidSpeed;

        newAsteroid.AddForce(AsteroidVelocity, ForceMode2D.Impulse);
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0) {
            Rigidbody2D newAsteroid = Instantiate(Prefab, SpawnPosition, Quaternion.identity);
            newAsteroid.transform.Rotate(0f, 0f, Random.Range(0f, 360f));

            Vector2 AsteroidVelocity = newAsteroid.transform.up * AsteroidSpeed;

            newAsteroid.AddForce(AsteroidVelocity, ForceMode2D.Impulse);
            timeLeft = 10;
        }
    }
}
