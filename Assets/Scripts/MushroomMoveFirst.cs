//add to RedMushroom001(1)
//ActualMushroom is 001 & ThisMushroom is 001(1)
using UnityEngine;
using System.Collections;

public class MushroomMoveFirst : MonoBehaviour
{
    public GameObject ActualMushroom;
    public GameObject ThisMushroom;

    void Update()
    {
        transform.parent = null;
        transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
        StartCoroutine(CloseAnim());
    }

    IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(0.1f);
        ActualMushroom.SetActive(true);
        ThisMushroom.SetActive(false);
    }

}