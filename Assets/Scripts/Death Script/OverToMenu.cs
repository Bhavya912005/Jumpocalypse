using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverToMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StartCoroutineFunction());
    }

    IEnumerator StartCoroutineFunction()
    {
        yield return new WaitForSeconds(4);

        // Assuming GlobalLives is a class with a static variable LivesAmount
        GlobalLives.LivesAmount += 3;

        // Assuming you want to load level 2
        SceneManager.LoadScene(2);
    }
}
