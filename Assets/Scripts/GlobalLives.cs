using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GlobalLives : MonoBehaviour
{
    public static int LivesAmount = 3;
    private int InternalLives;
    public GameObject LifeTextBox;

    void Update()
    {
        InternalLives = LivesAmount;
        LifeTextBox.GetComponent<TMPro.TextMeshProUGUI>().text = " " + InternalLives;

        if (InternalLives == 0)
        {
            StartCoroutine(GameOverScene());
        }
    }

    IEnumerator GameOverScene()
    {
        yield return new WaitForSeconds(5f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
