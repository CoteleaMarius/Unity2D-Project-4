using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _moveH, _moveV;
    [SerializeField] private float moveSpeed = 1.0f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _moveH = Input.GetAxis("Horizontal") * moveSpeed;
        _moveV = Input.GetAxis("Vertical") * moveSpeed;
        Vector2 direction = new Vector2(_moveH, _moveV);
        _rb.velocity = direction;
        FindObjectOfType<PlayerAnimation>().SetDirection(direction);
    }
}
