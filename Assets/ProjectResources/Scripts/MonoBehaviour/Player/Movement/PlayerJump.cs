using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    [SerializeField] private float jumpForce = 6f;

    private GroundChecker groundChecker;

    public PlayerJump()
    {
        
    }

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();

        groundChecker = GetComponent<GroundChecker>();
    }

    public void Jump()
    {
        if (groundChecker.IsGrounded)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            groundChecker.IsGrounded = false;
        }
    }
}