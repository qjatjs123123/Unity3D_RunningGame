using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_self : MonoBehaviour
{
    float rotSpeed = 25f;

    void Update()
    {
        self_Rotation();
    }

    void self_Rotation()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }
}
