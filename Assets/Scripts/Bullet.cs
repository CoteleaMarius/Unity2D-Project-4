using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.right * 100f, ForceMode2D.Impulse);
    }
}
