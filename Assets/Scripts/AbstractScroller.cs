using UnityEngine;

public abstract class AbstractScroller : MonoBehaviour
{
    [SerializeField]
    private float parallaxSpeed;

    [SerializeField]
    private float minPosition;

    private void Update()
    {
        Vector2 positionVector = transform.position;

        if (positionVector.x < minPosition)
        {
            OnEndReached(ref positionVector);
        }
        else
        {
            positionVector.x = transform.position.x + parallaxSpeed * Time.deltaTime;
        }
        transform.position = positionVector;
    }

    protected abstract void OnEndReached(ref Vector2 positionVector);
}