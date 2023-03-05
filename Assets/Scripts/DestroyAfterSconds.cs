using System.Collections;
using UnityEngine;

public class DestroyAfterSconds : MonoBehaviour
{
    [SerializeField]
    private float seconds;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(seconds);

        Destroy(gameObject);
    }
}