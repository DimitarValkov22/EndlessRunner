using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    private float rotateSpeed = 2.5f;
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
