using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private IMove move;

    private void Awake()
    {
        move = GetComponent<IMove>();
    }

    private void Update()
    {
        move.Move();
    }
}