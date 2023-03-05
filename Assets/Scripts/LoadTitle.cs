using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitle : MonoBehaviour
{
    private void OnDestroy()
    {
        SceneManager.LoadSceneAsync("Title");
    }
}
