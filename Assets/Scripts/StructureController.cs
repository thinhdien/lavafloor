using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

[RequireComponent(typeof(PlayerAssetsInputs))]
public class StructureController : MonoBehaviour
{
    private PlayerAssetsInputs _inputs;
    private PlayerInput _playerInputs;
    private Quaternion originalPos;

    private bool IsCurrentDeviceMouse
    {
        get
        {
#if ENABLE_INPUT_SYSTEM
            return _playerInputs.currentControlScheme == "KeyboardMouse";
#else
				return false;
#endif
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        _inputs = GetComponent<PlayerAssetsInputs>();
        _playerInputs = GetComponent<PlayerInput>();
        originalPos = transform.rotation;
    }

    // Update is called once per frame
    private void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        float targetSpeed = 0.12f;
        Quaternion startQuaternion = transform.rotation;
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(0, 90, 0);
        Vector3 inputDirection = new Vector3(_inputs.move.x, 0.0f, _inputs.move.y).normalized;
        Boolean isMove = false;
        if (_inputs.move != Vector2.up)
        {
            isMove = true;
            transform.Rotate(-inputDirection * Time.deltaTime * 15.0f, Space.Self);
            //transform.rotation = Quaternion.Lerp(startQuaternion,
        }
        else
        {
            isMove = false;
        }
        /*if (!isMove)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, originalPos, Time.time * 20f);
            if (transform.rotation == originalPos)
            {
                isMove = false;
            }
        }*/

        /*if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            if (Mathf.Abs(joystick.Horizontal) > Mathf.Abs(joystick.Vertical))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed * Mathf.Abs(joystick.Horizontal));
            }
            else if (Mathf.Abs(joystick.Horizontal) < Mathf.Abs(joystick.Vertical))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed * Mathf.Abs(joystick.Vertical));
            }
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            Debug.Log(Mathf.Abs(joystick.Horizontal) + " " + Mathf.Abs(joystick.Vertical) + " " + Mathf.Abs(joystick.Horizontal) * Mathf.Abs(joystick.Vertical));
            transform.LookAt(transform.localPosition + new Vector3(joystick.Horizontal, 0, joystick.Vertical));
        }*/
    }
}