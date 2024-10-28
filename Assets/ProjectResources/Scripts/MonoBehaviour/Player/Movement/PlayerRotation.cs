using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float sencetivity = 6f;

    private float currentHorizontalRotation = 0f;

    private void OnEnable()
    {
        NotifyMouseInput.OnPlayerInputedHorizontalMouse += RotatePlayer;
    }
    private void OnDisable()
    {
        NotifyMouseInput.OnPlayerInputedHorizontalMouse -= RotatePlayer;
    }

    private void RotatePlayer(float horizontalInput)
    {
        currentHorizontalRotation += horizontalInput * sencetivity;

        transform.localRotation = Quaternion.Euler(0f, currentHorizontalRotation, 0f);
    }
}
