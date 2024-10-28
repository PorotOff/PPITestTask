using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float runSpeed = 10f;

    private GroundChecker groundChecker;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    public void Move(float horizontalInput, float verticalInput, bool isShiftPressed)
    {
        Vector3 newMovementDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        newMovementDirection.Normalize();

        Vector3 currentVelocity = playerRigidbody.linearVelocity;
        Vector3 newVelocity = newMovementDirection * (isShiftPressed ? runSpeed : walkSpeed);
        newVelocity.y = currentVelocity.y;

        if (!groundChecker.IsGrounded)
        {
            newVelocity = currentVelocity;
        }

        playerRigidbody.linearVelocity = newVelocity;
    }
}
