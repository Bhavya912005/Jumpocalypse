using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01_Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSceneLoad());

    }

    IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }
}
