using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float acceleration = 10f;
    [SerializeField] private float sprintAcceleration = 18f;
    [SerializeField] private float rotateSpeed = 180f;
    [SerializeField] private float damping = 5f;
    
    [SerializeField] private InputActionAsset playerActionAsset;
    private InputAction _moveAction;
    private InputAction _sprintAction;

    private Rigidbody _rb;
    private Camera _camera;

    private Vector2 _moveInput;
    private Vector3 _targetVelocity;
    private bool _isSprinting;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _camera =  Camera.main;
        
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
        var camRotation = Quaternion.Euler(0, _camera.transform.eulerAngles.y, 0);
        var targetDirection = camRotation * new Vector3(_moveInput.x, 0, _moveInput.y).normalized;
        
        _targetVelocity += targetAcceleration * Time.fixedDeltaTime * targetDirection;
        _targetVelocity = Vector3.Lerp(_targetVelocity, Vector3.zero, damping * Time.fixedDeltaTime);
        
        _rb.MovePosition(_rb.position + _targetVelocity * Time.fixedDeltaTime);
        var targetRotation = Quaternion.LookRotation(_targetVelocity);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed * Time.fixedDeltaTime);
    }
}
