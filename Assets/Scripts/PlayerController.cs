using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Update()
    {
        transform.position = new Vector2(transform.position.x + 1 * Time.deltaTime, transform.position.y);
    }
}
