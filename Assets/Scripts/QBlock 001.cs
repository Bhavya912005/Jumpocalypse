using UnityEngine;
using System.Collections;

public class QBlock001 : MonoBehaviour
{
    public GameObject QBlock;
    public GameObject DeadBlock;
    public GameObject Mushroom;

    IEnumerator OnTriggerEnter(Collider col)
    {
        QBlock.SetActive(false);
        DeadBlock.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Mushroom.SetActive(true);
        //changed the QuestionBlock001Collision to be size 1, .7, 1 instead of smaller so that player doesn't get stuck in block
    }
}