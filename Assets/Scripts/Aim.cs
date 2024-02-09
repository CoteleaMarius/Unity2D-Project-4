using UnityEngine;

public class Aim : MonoBehaviour
{
    private Vector2 _screenPosition;
    private Vector2 _worldPosition;
    public GameObject gun;
    public GameObject player;
    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.sortingOrder = 1;
    }

    private void Update()
    {
        _screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        _worldPosition = Camera.main.ScreenToWorldPoint(_screenPosition);
        transform.right = new Vector3(_worldPosition.x, _worldPosition.y, 0) - transform.position;
        Debug.Log(transform.rotation.z);
        if (transform.rotation.z > -0.7f && transform.rotation.z < 0.7f)
        {
            _sprite.flipY = false;
        }
        else
        {
            _sprite.flipY = true;
        }
        if (player.GetComponent<PlayerMovement>().moveV > 0)
        {
            _sprite.sortingOrder = 1;
        }
        if (player.GetComponent<PlayerMovement>().moveV > 0)
        {
            _sprite.sortingOrder = 3;
        }
    }

}
