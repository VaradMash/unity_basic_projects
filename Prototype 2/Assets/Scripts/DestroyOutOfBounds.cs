﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperBoundary = 30.0f;
    private float lowerBoundary = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBoundary)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBoundary)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
