using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatering : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0f, 110 * Time.deltaTime, 0f, Space.Self);
    }
}