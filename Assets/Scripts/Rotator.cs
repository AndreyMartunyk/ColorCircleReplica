﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotateSpeed = 100f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, RotateSpeed * Time.deltaTime);  
    }
}
