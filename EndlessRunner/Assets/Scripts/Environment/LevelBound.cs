using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBound : MonoBehaviour
{
    public static float leftSide = -5.3f;
    public static float rightSide = 5.2f;
    public float internalLeft;
    public float internalRight;


    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
