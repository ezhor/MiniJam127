using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private KeyCode upKey;

    [SerializeField]
    private KeyCode downKey;

    [SerializeField]
    private KeyCode leftKey;

    [SerializeField]
    private KeyCode rightKey;

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

        if (Input.GetKey(rightKey))
        {
            velocity.x = 1;
        }
        else if (Input.GetKey(leftKey))
        {
            velocity.x = -1;
        }

        if (Input.GetKey(downKey))
        {
            velocity.y = -1;
        }
        else if (Input.GetKey(upKey))
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
