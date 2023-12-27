
using UnityEngine;
using System.Collections;

public class MushroomBossDeath : MonoBehaviour
{
    public GameObject MushroomMan;

    void OnTriggerEnter(Collider col)
    {
        GetComponent<BoxCollider>().enabled = false;
        MushroomMan.GetComponent<MushroomManMove>().enabled = false;
        MushroomMan.transform.localScale -= new Vector3(0, 0, 1.8f);
        MushroomMan.transform.localPosition -= new Vector3(0, 0, 1.4f);
        GlobalScore.CurrentScore += 100;
        StartCoroutine(WaitAndMoveMushroomMan());
    }

    IEnumerator WaitAndMoveMushroomMan()
    {
        yield return new WaitForSeconds(0);
        MushroomMan.transform.position = new Vector3(0, -1000, 0);
        yield return new WaitForSeconds(2);
        // Assuming you're using Unity 5.4 or later, as Application.LoadLevel is deprecated
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
}
