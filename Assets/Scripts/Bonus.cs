using UnityEngine;

public class Bonus : MonoBehaviour
{

    private GameObject _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            _gameManager.GetComponent<SpawnJewel>().jewelCount++;
        }else if (other.gameObject.CompareTag("Collider"))
        {
            Destroy(gameObject);
        }
    }
}
