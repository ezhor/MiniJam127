using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector2 bounds;

    private void Update()
    {
        MovePlayer();
        CheckBounds();
    }

    private void MovePlayer()
    {
        Vector2 velocity = new Vector2();

        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 1;
        }

        transform.Translate(velocity.normalized * speed * Time.deltaTime);

    }

    private void CheckBounds()
    {
        Vector2 position;

        position.x = Mathf.Clamp(transform.position.x, -bounds.x, bounds.x);
        position.y = Mathf.Clamp(transform.position.y, -bounds.y, bounds.y);

        transform.position = position;
    }
}
