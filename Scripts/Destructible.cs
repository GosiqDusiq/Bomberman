using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float destructionTime = 1f;

<<<<<<< Updated upstream
    [Range(0f, 1f)]
    public float itemSpawnChance = 0.2f;
    public GameObject[] spawnableItems;

=======
>>>>>>> Stashed changes
    private void Start()
    {
        Destroy(gameObject, destructionTime);
    }
<<<<<<< Updated upstream

    private void OnDestroy()
    {
        if (spawnableItems.Length > 0 && Random.value < itemSpawnChance)
        {
            int randomIndex = Random.Range(0, spawnableItems.Length);
            Instantiate(spawnableItems[randomIndex], transform.position, Quaternion.identity);
        }
    }

=======
>>>>>>> Stashed changes
}
