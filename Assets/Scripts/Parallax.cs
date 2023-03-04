using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    private float parallaxSpeed;

    [SerializeField]
    private float spawnPosition;

    [SerializeField]
    private float minPosition;

    // Update is called once per frame
    void Update()
    {
        Displacement();
    }

    private void Displacement()
    {
        Vector2 positionVector = transform.position;

        if (positionVector.x < minPosition)
        {
            positionVector.x = spawnPosition;
        }
        else
        {
            positionVector.x = transform.position.x + parallaxSpeed * Time.deltaTime;
        }

        transform.position = positionVector;
    }
}
