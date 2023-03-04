using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private KeyCode shootKey;

    [SerializeField]
    private float shootDelay;

    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private Transform projectileSpawn;

    private bool canShoot = true;


    private void Update()
    {
        if (canShoot && Input.GetKeyDown(shootKey))
        {
            StartCoroutine(ShootCoroutine());
        }
    }

    private IEnumerator ShootCoroutine()
    {
        canShoot = false;

        Instantiate(projectilePrefab, projectileSpawn.position, Quaternion.identity);

        yield return new WaitForSeconds(shootDelay);

        canShoot = true;
    }
}