using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public AudioSource CoinCollector;
    void OnTriggerEnter(Collider col)
    {
        transform.position = new Vector3(0, -1000, 0);
        CoinCollector.Play();
         GlobalCoins.CoinCount += 1;
        GlobalScore.CurrentScore += 10;    }


}

