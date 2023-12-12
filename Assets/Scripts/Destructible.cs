using UnityEngine;
using UnityEngine.Tilemaps;

public class Destructible : MonoBehaviour
{
    public float destructionTime = 1f;
    public GameObject destructiblePrefab;
    public Tilemap destructibleTiles;

    [Range(0f, 1f)]
    public float itemSpawnChance = 0.2f;
    public GameObject[] spawnableItems;

    
    private void Start()
    {
        Destroy(gameObject, destructionTime);
    }

    private void OnDestroy()
    {
        if (destructibleTiles != null)
        {
            Vector3Int cellPosition = destructibleTiles.WorldToCell(transform.position);
            TileBase tile = destructibleTiles.GetTile(cellPosition);
            Debug.Log("text: TileFounded.text");

            if (tile != null)
            {
                // Instantiate destructiblePrefab and remove the tile
                Instantiate(destructiblePrefab, destructibleTiles.GetCellCenterWorld(cellPosition), Quaternion.identity);
                destructibleTiles.SetTile(cellPosition, null);

                if (spawnableItems.Length > 0 && Random.value < itemSpawnChance)
                {
                    int randomIndex = Random.Range(0, spawnableItems.Length);
                    Instantiate(spawnableItems[randomIndex], transform.position, Quaternion.identity);
                }
            }
        }
    }
}
