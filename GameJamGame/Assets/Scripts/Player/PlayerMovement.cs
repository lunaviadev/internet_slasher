using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 8f;
    public float acceleration = 50f;
    public float deceleration = 100f;

    private Rigidbody2D rb;
    private Vector2 input;
    private Vector2 velocity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get raw input so we have instant direction switching
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        input = new Vector2(x, y).normalized; // normalized to avoid faster diagonals
    }

    private void FixedUpdate()
    {
        Vector2 targetVelocity = input * moveSpeed;

        Vector2 velocityDiff = targetVelocity - velocity;

        float accelRate = (input.magnitude > 0.1f) ? acceleration : deceleration;

        Vector2 movement = velocity + velocityDiff.normalized * accelRate * Time.fixedDeltaTime;

        if (Vector2.Distance(Vector2.zero, targetVelocity) < Vector2.Distance(Vector2.zero, movement))
            movement = targetVelocity;

        velocity = movement;

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

}
