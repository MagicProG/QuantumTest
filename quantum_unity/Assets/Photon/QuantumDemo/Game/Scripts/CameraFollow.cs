using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    
    [SerializeField]
    private Vector3 offset = new Vector3(0,8, -10);

    public void SetTarget(Transform t) => _target = t;
    
    private void LateUpdate()
    {
        if (_target == null)
            return;
        
        Vector3 position = _target.transform.position;

        Transform t = transform;

        t.position = position + offset;
        t.LookAt(_target);
    }
    
}