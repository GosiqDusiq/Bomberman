using UnityEngine;

public class BotController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to set the bot's movement speed.
    public string destroyTag = "DestroyableObject"; // Set the tag of the object that should destroy the player.

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement.normalized * moveSpeed;

        // You can also use transform.position for 3D objects:
        // Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        // transform.Translate(movement.normalized * moveSpeed * Time.deltaTime);
    }

    // Handle collision with destroyable objects.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(destroyTag))
        {
            // Destroy the player when they touch the object with the specified tag.
            Destroy(gameObject); // Destroy the bot (player).
            // You can add more logic here, like game over or respawn, as needed.
        }
    }
}
