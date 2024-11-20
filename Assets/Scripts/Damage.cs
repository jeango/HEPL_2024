using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool onExit;
    public bool onEnter;
    public bool canKill;
    public string[] tagsToDamage;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (onEnter) ApplyDamage(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (onExit) ApplyDamage(other);
    }

    void ApplyDamage(Collider2D other)
    {
        if (tagsToDamage.Contains(other.gameObject.tag))
        {
            if (other.attachedRigidbody != null)
            {
                KillOrDestroy(other.attachedRigidbody.gameObject);
            }
            else
            {
                KillOrDestroy(other.gameObject);
            }            
        }        
    }
    
    void KillOrDestroy(GameObject objectToKill)
    {
        var deathCtrl = objectToKill?.GetComponent<DeathManager>();
        if (canKill && deathCtrl)
        {
            deathCtrl.Kill();
        }
        else
        {
            Destroy(objectToKill);
        }
    }
}
