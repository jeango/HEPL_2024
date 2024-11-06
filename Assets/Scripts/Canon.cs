using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    public void Fire(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
