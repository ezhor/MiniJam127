using UnityEngine;

public class Parallax : AbstractScroller
{
    [SerializeField]
    private float spawnPosition;

    protected override void OnEndReached(Vector2 positionVector)
    {
        positionVector.x = spawnPosition;
    }
}
