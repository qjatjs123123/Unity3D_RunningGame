using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTrap2 : MonoBehaviour
{
    public float rSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * rSpeed, 0);
    }
}
