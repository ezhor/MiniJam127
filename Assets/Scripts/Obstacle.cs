using System.Collections;
using UnityEngine;

public class Obstacle : AbstractScroller
{
    protected override void OnEndReached(Vector2 positionVector)
    {
        Destroy(gameObject);
    }
}