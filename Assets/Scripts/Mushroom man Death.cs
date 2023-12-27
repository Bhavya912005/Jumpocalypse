
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomManDeath : MonoBehaviour
{

    public GameObject MushroomMan;


    IEnumerator OnTriggerEnter(Collider col)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MushroomMan.GetComponent<MushroomManMove>().enabled = false;
        MushroomMan.transform.localScale -= new Vector3(0, 0F, 0);
        MushroomMan.transform.localPosition -= new Vector3(0, 0F, 0);
        GlobalScore.CurrentScore += 100;    

    yield return new WaitForSeconds(0);
        MushroomMan.transform.position = new Vector3(0, -1000, 0);

    }
}