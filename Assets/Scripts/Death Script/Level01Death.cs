using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class Level01Death : MonoBehaviour
{
    public AudioSource DeathSound;
    public AudioSource LevelMusic;
    public GameObject CamFollow;
    public GameObject ThePlayer;

    void OnTriggerEnter(Collider col)
    {

        DeathSound.GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForDeath());
    }

    IEnumerator WaitForDeath()
    {
        GlobalLives.LivesAmount -= 1;
        LevelMusic.GetComponent<AudioSource>().enabled = false;
        CamFollow.GetComponent<CameraFollow>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        ThePlayer.GetComponent<ThirdPersonUserControl>().enabled = false;
        ThePlayer.GetComponent<ThirdPersonCharacter>().enabled = false;

        ThePlayer.transform.localScale -= new Vector3(0.0f, 0.0f, 0.0f);
        GlobalScore.CurrentScore = 0;
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene(1);
    }
}

