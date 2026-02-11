using UnityEngine;

public class HeadAiming : MonoBehaviour
{
    [SerializeField] private Transform player;

    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }
    
    private void FixedUpdate()
    {
        Aim();
    }
    
    private void Aim()
    {
        var (success, position) = GetMousePosition();
        if (success)
        {
            var direction = position - player.position;
            transform.forward = direction.normalized;
        }
    }
    
    private (bool success, Vector3 position) GetMousePosition()
    {
        var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

        return Physics.Raycast(ray, out var hitInfo, Mathf.Infinity)
            ? (success: true, position: hitInfo.point)
            : (success: false, position: Vector3.zero);
    }
}
