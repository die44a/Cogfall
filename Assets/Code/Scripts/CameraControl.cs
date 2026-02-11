using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform rotationPivot;
    [SerializeField] private InputActionAsset playerActionAsset;
    
    private InputAction _rotateAction;
    
    private void Awake()
    {
        _rotateAction = playerActionAsset.FindAction("RotateCamera");
    }

    private void OnEnable()
    {
        _rotateAction.Enable();
        _rotateAction.started += OnRotate;
    }

    private void OnDisable()
    {
        _rotateAction.Disable();
        _rotateAction.started -= OnRotate;
    }
    
    private void OnRotate(InputAction.CallbackContext context)
    {
        var axisValue = context.ReadValue<float>();
        if (axisValue > 0.1f)
            Rotate(90f);
        else
            Rotate(-90f);
    }

    private void Rotate(float delta)
    {
        rotationPivot.Rotate(Vector3.up, delta, Space.World);    }
}