using System;
using UnityEngine;

public class NotifyMouseInput : MonoBehaviour
{
    public static event Action<float> OnPlayerInputedHorizontalMouse;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X");

        if (horizontalInput != 0) OnPlayerInputedHorizontalMouse?.Invoke(horizontalInput);
    }
}