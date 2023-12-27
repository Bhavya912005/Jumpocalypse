using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomGreenCollect : MonoBehaviour
{
    public AudioSource LifeSound;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(0, -1000, 0);
            LifeSound.GetComponent<AudioSource>().Play();

            GlobalLives.LivesAmount += 1;
        }
    }
}