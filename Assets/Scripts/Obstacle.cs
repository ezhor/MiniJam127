using System.Collections;
using UnityEngine;

public class Obstacle : AbstractScroller
{
    protected override void OnEndReached(ref Vector2 positionVector)
    {
        Destroy(gameObject);
    }
}