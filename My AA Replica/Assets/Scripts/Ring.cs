﻿using UnityEngine;

public class Ring : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f, 0f, -40f * Time.deltaTime);
    }
}
