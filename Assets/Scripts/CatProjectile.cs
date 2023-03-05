using UnityEngine;

public class CatProjectile : MonoBehaviour
{
    [SerializeField]
    private GameObject[] faces;

    [SerializeField]
    private float speed;

    private void Start()
    {
        SelectFace();

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0f);
    }

    private void SelectFace()
    {
        int random = Random.Range(0, faces.Length);

        for (int i = 0; i < faces.Length; i++)
        {
            faces[i].SetActive(i == random);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}