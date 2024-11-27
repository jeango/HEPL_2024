using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject deathEffect;
    public int scoreOnDeath;

    public void Kill()
    {
        GameManager.score += scoreOnDeath;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
