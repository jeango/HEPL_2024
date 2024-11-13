using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool onExit;
    public bool onEnter;
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
                Destroy(other.attachedRigidbody.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }            
        }        
    }
}
