using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum ItemType
    {
        ExtraBomb,
        BlastRadius,
        SpeedIncrease,
        Health,
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

            case ItemType.Health:
                // Assuming you have a script or component for managing player health
                IPlayerHealth playerHealth = player.GetComponent<IPlayerHealth>();

                if (playerHealth != null)
                {
                    playerHealth.SetHealth(playerHealth.GetHealth() + 1);
                    Debug.Log("Health added!");
                }
                else
                {
                    Debug.LogError("Player is missing a component implementing IPlayerHealth.");
                }
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
