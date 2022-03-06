﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 3.0f;
    MeshRenderer meshRenderer = null;
    Rigidbody rigidBody = null;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait ) {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true; 
        }
    }
}
