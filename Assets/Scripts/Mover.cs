﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zMovement = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(xMovement * moveSpeed, 0.0f, zMovement * moveSpeed);
    }
}