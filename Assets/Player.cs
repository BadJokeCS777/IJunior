using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _lookSpeed;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private ObjectPicker _objectPicker;

    private PlayerInput _playerInput;
    private Vector2 _lookDirection;
    private Vector2 _moveDirection;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        // _playerInput.Player.Look.performed += OnLook;
        // _playerInput.Player.Move.performed += OnMove;
        // _playerInput.Player.Look.canceled += OnLook;
        // _playerInput.Player.Move.canceled += OnMove;

        _playerInput.Player.Pick.performed += ctx => _objectPicker.PickUp();
        _playerInput.Player.Drop.performed += ctx => _objectPicker.Drop();
        _playerInput.Player.Throw.performed += ctx => _objectPicker.Throw();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        _lookDirection = _playerInput.Player.Look.ReadValue<Vector2>();
        _moveDirection = _playerInput.Player.Move.ReadValue<Vector2>();
        
        Look();
        Move();
    }

    private void Look()
    {
        if (_lookDirection.sqrMagnitude < 0.1f)
            return;
        
        float scaledLookSpeed = _lookSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(-_lookDirection.y, _lookDirection.x, 0f) * scaledLookSpeed;
        
        transform.Rotate(offset);
    }

    private void Move()
    {
        if (_moveDirection.sqrMagnitude < 0.1f)
            return;
        
        float scaledMoveSpeed = _moveSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(_moveDirection.x, 0f, _moveDirection.y) * scaledMoveSpeed;
        
        transform.Translate(offset);
    }

    private void OnLook(InputAction.CallbackContext context)
    {
        _lookDirection = context.action.ReadValue<Vector2>();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = context.action.ReadValue<Vector2>();
    }
}