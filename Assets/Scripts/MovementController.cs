using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public bool boosting = false;
    public Rigidbody2D body;

    void Update()
    {
        if (!body || body.isKinematic)
        {
            Move();
        }
    }

    void FixedUpdate()
    {
        if (body && !body.isKinematic)
        {
            MoveDynamic();
        }
    }
    void MoveDynamic()
    {
        body.velocity = direction * speed;
    }

    public void SetDirection(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    public void SetBoosting(InputAction.CallbackContext context)
    {
        boosting = context.ReadValueAsButton();
        print (boosting);
    }
    
    void Move()
    {
        var pos = transform.position;
        var boostedSpeed = boosting ? speed*2 : speed;
        pos = pos + (Vector3)direction.normalized * (boostedSpeed * Time.deltaTime);
        transform.position = pos ;
    }


}
