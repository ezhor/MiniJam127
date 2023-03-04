using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private bool loading;

    private void Update()
    {
        if (Input.anyKeyDown && !loading)
        {
            loading = true;
            SceneManager.LoadSceneAsync("Game");
        }
    }
}
