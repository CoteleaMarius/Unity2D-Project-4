using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnJewel : MonoBehaviour
{
    public GameObject jewel;
    public int jewelCount;
    public Text jewelText;
    private void Start()
    {
        StartCoroutine(nameof(Spawn));
    }

    private void Update()
    {
        jewelText.text = "Score: " + jewelCount.ToString();
    }
    
    IEnumerator Spawn(){
        while(true)
        {
            if (Camera.main != null)
            {
                Vector2 bottomLeft =  Camera.main.ViewportToWorldPoint(new Vector2(0,0));
                Vector2 topRight = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

                float x = Random.Range(bottomLeft.x ,topRight.x);
                float y = Random.Range(bottomLeft.y ,topRight.y);

                Instantiate(jewel, new Vector3(x, y , 0), Quaternion.identity);
            }

            yield return new WaitForSeconds(10f);
        }
    }

    
}
