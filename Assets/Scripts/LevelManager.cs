using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tunnelPrefabs;

    [SerializeField]
    private Vector2 obstacleSpawn;

    [SerializeField]
    private float obstacleLimit;
}
