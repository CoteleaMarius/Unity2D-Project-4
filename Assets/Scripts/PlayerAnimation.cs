using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private static readonly string[] StaticDirections =
        { "StaticN", "StaticNW", "StaticW", "StaticSW", "StaticS", "StaticSE", "StaticE", "StaticNE" };

    private static readonly string[] RunDirections =
        { "RunN", "RunNW", "RunW", "RunSW", "RunS", "RunSE", "RunE", "RunNE" };

    private Animator _animator;
    private int _lastDirection;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetDirection(Vector2 direction)
    {
        string[] directionArray;
        if (direction.magnitude < 0.01)
        {
            directionArray = StaticDirections;
        }
        else
        {
            directionArray = RunDirections;
            _lastDirection = DirectionToIndex(direction);
        }

        _animator.Play(directionArray[_lastDirection]);
    }

    private int DirectionToIndex(Vector2 direction)
    {
        Vector2 norDir = direction.normalized;
        float step = 45;
        float offset = step / 2;
        float angle = Vector2.SignedAngle(Vector2.up, norDir);
        angle += offset;
        if (angle < 0)
        {
            angle += 360;
        }

        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }
}