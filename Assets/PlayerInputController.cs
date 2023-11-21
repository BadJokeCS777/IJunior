using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class PlayerInputController : MonoBehaviour
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Player.Shoot.performed += OnShoot;
        _playerInput.Player.Move.performed += OnMove;
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void OnShoot(InputAction.CallbackContext context)
    {
        Debug.Log("Shoot");
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveDirection  = context.action.ReadValue<Vector2>();
        Debug.Log(moveDirection );
    }
}