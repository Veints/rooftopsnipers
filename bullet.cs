using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifespan = 2f;

    void Start()
    {
        Destroy(gameObject, lifespan);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Add logic for damaging player
            Destroy(gameObject);
        }
    }
}
