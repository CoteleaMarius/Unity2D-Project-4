using UnityEngine;
using UnityEngine.Tilemaps;

public class HideTilemapColliderOnPlay : MonoBehaviour
{
    private TilemapRenderer _tilemapRenderer;

    void Start()
    {
        _tilemapRenderer = GetComponent<TilemapRenderer>();
        _tilemapRenderer.enabled = false;
    }
    
}
