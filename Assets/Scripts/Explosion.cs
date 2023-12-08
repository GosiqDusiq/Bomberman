using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AnimatedSpriteRenderer start;
    public AnimatedSpriteRenderer middle;
    public AnimatedSpriteRenderer end;

    public void SetActiveRenderer(AnimatedSpriteRenderer renderer)
    {
<<<<<<< Updated upstream
        start.enabled = (renderer == start);
        middle.enabled = (renderer == middle);
        end.enabled = (renderer == end);
=======
        start.enabled = renderer == start;
        middle.enabled = renderer == middle;
        end.enabled = renderer == end;
>>>>>>> Stashed changes
    }

    public void SetDirection(Vector2 direction)
    {
        float angle = Mathf.Atan2(direction.y, direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }

    public void ClearAllTiles(float seconds)
    {
        Destroy(gameObject, seconds);
    }

}