using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyUICanvasControllerInput : MonoBehaviour
{
    public PlayerAssetsInputs assetsInputs;

    public void VirtualMoveInput(Vector2 virtualMoveDirection)
    {
        assetsInputs.MoveInput(virtualMoveDirection);
    }
}