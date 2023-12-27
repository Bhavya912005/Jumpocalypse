using UnityEngine;

public class BossTrigFreeze : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject BackWall;

    void OnTriggerEnter(Collider other)
    {
        MainCam.GetComponent<CameraFollow>().enabled = false;
        BackWall.SetActive(true);
    }
}

