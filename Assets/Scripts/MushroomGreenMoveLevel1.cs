using UnityEngine;
using System.Collections;

public class MushroomGreenMoveLevel : MonoBehaviour
{
    float LeftPoint = 1f;
    float RightPoint = 3f;
    int Direction = 1;  //  1 = moving right, 2 = moving left


    void Update()
    {
        if (Direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            Direction = 1;
        }

        if (this.transform.position.x > RightPoint)
        {
            Direction = 2;
        }

        if (Direction == 2)
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
            Direction = 2;
        }

        if (this.transform.position.x < LeftPoint)
        {
            Direction = 1;
        }
    }
}
