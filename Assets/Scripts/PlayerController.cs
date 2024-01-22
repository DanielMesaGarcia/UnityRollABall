using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private bool canJump = true;
    public float speed = 5.0f;
    public float jumpForce = 6.0f;
    public float jumpCooldown = 1.0f; // Tiempo de cooldown en segundos

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && canJump)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();
        movementX = movement.x;
        movementY = movement.y;
    }

    void Jump()
    {
        Vector3 jump = new Vector3(0.0f, jumpForce, 0.0f);
        rb.AddForce(jump, ForceMode.Impulse);
        canJump = false; // Desactiva la posibilidad de saltar
        StartCoroutine(EnableJumpAfterCooldown()); // Inicia el temporizador de cooldown
    }

    IEnumerator EnableJumpAfterCooldown()
    {
        yield return new WaitForSeconds(jumpCooldown);
        canJump = true; // Activa la posibilidad de saltar después del cooldown
    }
}
