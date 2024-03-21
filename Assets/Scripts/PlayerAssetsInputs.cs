using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAssetsInputs : MonoBehaviour
{
    public Vector2 move;

#if ENABLE_INPUT_SYSTEM

    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

#endif

    public void MoveInput(Vector2 newMoveDirection)
    {
        move = newMoveDirection;
    }
}