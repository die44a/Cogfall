using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float acceleration = 1f;
    [SerializeField] private float sprintAcceleration = 2f;
    [SerializeField] private float damping = 2f;
    private Vector3 _targetVelocity;
    
    [SerializeField] private InputActionAsset playerActionAsset;

    private Rigidbody _rb;

    private InputAction _moveAction;
    private InputAction _sprintAction;
    private Vector2 _moveInput;
    private bool _isSprinting;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();

        var playerMap = playerActionAsset.FindActionMap("Player");

        _moveAction = playerMap.FindAction("Move");
        _sprintAction = playerMap.FindAction("Sprint");
    }

    private void OnEnable()
    {
        _moveAction.Enable();
        _sprintAction.Enable();
    }

    private void OnDisable()
    {
        _moveAction.Disable();
        _sprintAction.Disable();
    }

    private void ReadInput()
    {
        _moveInput = _moveAction.ReadValue<Vector2>();
        _isSprinting = _sprintAction.ReadValue<float>() > 0;
    }
    
    private void FixedUpdate()
    {
        ReadInput();
        Move();
    }

    private void Move()
    {
        var targetAcceleration = _isSprinting ? sprintAcceleration : acceleration;
        var targetDirection = Quaternion.Euler(0, 45f, 0) * new Vector3(_moveInput.x, 0, _moveInput.y).normalized;
        
        _targetVelocity += targetAcceleration * Time.fixedDeltaTime * targetDirection;
        _targetVelocity = Vector3.Lerp(_targetVelocity, Vector3.zero, damping * Time.fixedDeltaTime);
        
        _rb.MovePosition(_rb.position + _targetVelocity);
    }
}
