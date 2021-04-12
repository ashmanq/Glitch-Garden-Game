using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float waitTimeBeforeStart = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadStartScene());
    }

    IEnumerator loadStartScene()
    {
        yield return new WaitForSeconds(waitTimeBeforeStart);
        SceneManager.LoadScene("Start Screen");
    }
}
