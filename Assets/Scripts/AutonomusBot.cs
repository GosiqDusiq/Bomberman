using UnityEngine;
using UnityEngine.Tilemaps;

public class AutonomousBot : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public Tilemap tilemap;
    public TileBase stopperTile;
    public float raycastDistance = 1.0f;
    public LayerMask obstacleLayer;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 movementDirection = GetRandomDirection();

        // Check for obstacles using raycast
        RaycastHit2D hit = Physics2D.Raycast(transform.position, movementDirection, raycastDistance, obstacleLayer);

        if (hit.collider != null)
        {
            rb.velocity = Vector2.zero; // Stop moving if an obstacle is detected.
        }
        else
        {
            // Move the bot in the chosen direction.
            rb.velocity = movementDirection.normalized * moveSpeed;
        }
    }

    private Vector2 GetRandomDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        return new Vector2(randomX, randomY);
    }
}
