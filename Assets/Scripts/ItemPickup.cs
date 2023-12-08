using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum ItemType
    {
        ExtraBomb,
        BlastRadius,
        SpeedIncrease,
    }

    public ItemType type;

    private void OnItemPickup(GameObject player)
    {
        switch (type)
        {
            case ItemType.ExtraBomb:
                player.GetComponent<BombController>().AddBomb();
                Debug.Log("Bomb added!");
                break;

            case ItemType.BlastRadius:
                player.GetComponent<BombController>().explosionRadius++;
                Debug.Log("Explosion radius increased!");
                break;

            case ItemType.SpeedIncrease:
                player.GetComponent<MovementController>().speed++;
                Debug.Log("Speed increased!");
                break;
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            OnItemPickup(other.gameObject);
        }
    }

}
