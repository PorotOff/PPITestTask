using UnityEngine;

public class PlayerWalking : MonoBehaviour, IMove
{
    private PlayerMovement playerMovement;

    private Rigidbody playerRigidbody;

    [SerializeField] private float walkSpeed = 5f;
    protected float currentSpeed;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private Vector3 GetMovementDirection(float horizontalInput, float verticalInput)
    {
        Vector3 newMovementDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        newMovementDirection.Normalize();

        return newMovementDirection;
    }

    public void Move(float horizontalInput, float verticalInput)
    {
        Vector3 newMovementDirection = GetMovementDirection(horizontalInput, verticalInput);

        Vector3 currentVelocity = playerRigidbody.linearVelocity;
        Vector3 newVelocity = newMovementDirection * (isShiftPressed ? runSpeed : walkSpeed);
        newVelocity.y = currentVelocity.y;

        playerRigidbody.linearVelocity = newVelocity;
    }
}