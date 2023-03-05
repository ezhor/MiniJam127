using UnityEngine;

public class Parallax : AbstractScroller
{
    [SerializeField]
    private float spawnPosition;

    protected override void OnEndReached(ref Vector2 positionVector)
    {
        positionVector.x = spawnPosition;
    }
}
