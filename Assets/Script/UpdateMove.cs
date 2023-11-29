using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{
    public float speed = 3;

    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
