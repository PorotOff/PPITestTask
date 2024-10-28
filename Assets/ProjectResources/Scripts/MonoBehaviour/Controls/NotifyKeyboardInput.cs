using System;
using UnityEngine;

public class NotifyKeyboardInput : MonoBehaviour
{
    // Pressing
    public static event Action<float> OnPlayerPressingWS;
    public static event Action<float> OnPlayerPressingAD;

    public static event Action OnPlayerPressingShift;

    // Pressed
    public static event Action OnPlayerPressedSpace;

    private void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if (verticalInput != 0) OnPlayerPressingWS?.Invoke(verticalInput);
        if (horizontalInput != 0) OnPlayerPressingAD?.Invoke(horizontalInput);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) OnPlayerPressingShift?.Invoke();

        if (Input.GetKeyDown(KeyCode.Space)) OnPlayerPressedSpace?.Invoke();
    }
}