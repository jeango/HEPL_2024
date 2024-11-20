using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject deathEffect;

    public void Kill()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
