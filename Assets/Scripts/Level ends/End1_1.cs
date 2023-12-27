using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End1_1 : MonoBehaviour
{
    public GameObject FadeScreen;
    public GameObject ThePlayer;
    public int TimeScore;
    public int TimeLeftInt;

    void OnTriggerEnter()
    {
        StartCoroutine(EndFadeScreen());
    }

    IEnumerator EndFadeScreen()
    {
        FadeScreen.SetActive(true);
        FadeScreen.GetComponent<Animator>().enabled = true;
        TimeLeftInt = CountingDown.TimeLeft;
        TimeScore = TimeLeftInt * 10;
        GlobalScore.CurrentScore += TimeScore;
        yield return new WaitForSeconds(0.495f);
        FadeScreen.GetComponent<Animator>().enabled = false;
        SceneManager.LoadScene(4);
    }
}