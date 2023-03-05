﻿using System.Collections;
using UnityEngine;

public class Killable : MonoBehaviour
{
    [SerializeField]
    private GameObject ghostPrefab;

    [SerializeField]
    private float ghostSpeed;

    [SerializeField]
    private string killerTag;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(killerTag))
        {
            Instantiate(ghostPrefab, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(0f, ghostSpeed);
            Destroy(gameObject);
        }
    }
}