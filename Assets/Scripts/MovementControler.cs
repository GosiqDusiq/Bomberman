using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementControler : MonoBehaviour
{
    public new Rigidbody2D rigidbody { get; private set; }
    private Vector2 direction = Vector2.down;
    public float speed = 5f;

    [Header("Input")]
    public KeyCode inputUp = KeyCode.W;
    public KeyCode inputDown = KeyCode.S;
    public KeyCode inputLeft = KeyCode.A;
    public KeyCode inputRight = KeyCode.D;

    [Header("Sprites")]
    public AnimatedSpriteRenderer spriteRendererUp;
    public AnimatedSpriteRenderer spriteRendererDown;
    public AnimatedSpriteRenderer spriteRendererLeft;
    public AnimatedSpriteRenderer spriteRendererRight;
    public AnimatedSpriteRenderer spriteRendererDeath;
    private AnimatedSpriteRenderer activeSpriteRenderer;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        activeSpriteRenderer = spriterendererDown;
    }

    private void Update()
    {
        if (Input.GetKey(inputUp)) {
            SetDirection(Vector2.up, spriterendererUp);
        } else if (Input.GetKey(inputDown)) {
            SetDirection(Vector2.down, spriterendererDown);
        } else if (Input.GetKey(inputLeft)) {
            SetDirection(Vector2.left, spriterendererLeft);
        } else if (Input.GetKey(inputRight)) {
            SetDirection(Vector2.right, spriterendererRight);
        } else {
            SetDirection(Vector2.zero, activeSpriteRenderer);
        }
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidbody.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;
    
        rigidbody.MovePosition(position + translation);
    }

    private void SetDirection(Vector2 newDirection, AnimatedSpriteRenderer spriteRenderer)
    {
        direction = newDirection;

        spriterendererUp.enabled = spriteRenderer == spriterendererUp;
        spriterendererDown.enabled = spriteRenderer == spriterendererDown;
        spriterendererLeft.enabled = spriteRenderer == spriterendererLeft;
        spriterendererRight.enabled = spriteRenderer == spriterendererRight;

        activeSpriteRenderer = spriteRenderer;
        activeSpriteRenderer.idle = direction == Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Explosion")) {
            DeathSequence();
        }
    }

    private void DeathSequence()
    {
        enabled = false;
        GetComponent<BombController>().enabled = false;

        spriterendererUp.enabled = false;
        spriterendererDown.enabled = false;
        spriterendererLeft.enabled = false;
        spriterendererRight.enabled = false;
        spriteRendererDeath.enabled = true;

        Invoke(nameof(OnDeathSequenceEnded), 1.25f);
    }

    private void OnDeathSequenceEnded()
    {
        gameObject.SetActive(false);
    }
}
