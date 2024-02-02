using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 _startingPosition;
    public Transform followTarget;
    private Vector3 _targetPosition;
    public float moveSpeed;

    private void Start()
    {
        _startingPosition = transform.position;
    }

    private void Update()
    {
        if (followTarget != null)
        {
            var position = followTarget.position;
            var position1 = transform.position;
            _targetPosition = new Vector3(position.x, position.y, position1.z);
            Vector3 velocity = (_targetPosition - position1) * moveSpeed;
            position1 =
                Vector3.SmoothDamp(position1, _targetPosition, ref velocity, 1.0f, Time.deltaTime);
            transform.position = position1;
        }
    }
}
