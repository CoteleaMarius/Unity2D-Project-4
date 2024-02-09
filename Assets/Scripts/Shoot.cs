using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
