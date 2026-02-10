using UnityEngine;

public class PlayerCameraRoot : MonoBehaviour
{
    [SerializeField] private Transform player;

    private Vector3 _offset = new Vector3(0, 2, 0);
    private float _forwardOffset = 1f;
    
    private void LateUpdate()
    {
        var forwardShift = player.forward * _forwardOffset;
        transform.position = player.position + forwardShift + _offset;
    }
}
