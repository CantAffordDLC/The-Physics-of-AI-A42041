﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    public float speed = 3;

    void LateUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
