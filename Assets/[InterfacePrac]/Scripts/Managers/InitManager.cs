using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitManager : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return SceneManager.LoadSceneAsync((1), LoadSceneMode.Additive);
        yield return SceneManager.LoadSceneAsync((2), LoadSceneMode.Additive);
        Destroy(gameObject);
    }
}