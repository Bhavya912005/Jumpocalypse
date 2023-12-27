using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeScroll : MonoBehaviour
{
    public float ResetPoint;
    public float CurrentPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ResetPoint = 6.52f;
        CurrentPoint = transform.position.y;
        if (CurrentPoint >= ResetPoint)
        {
            transform.position = new Vector3(14f, -3.76f, 0.5f); // Adjust to respawn location for your game
        }
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}

