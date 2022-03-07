using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotationSpeed = 150f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!!!");
    }

    void MovePlayer()
    {
        float yRotation = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zMovement = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(0.0f, 0.0f, zMovement * moveSpeed);
        transform.Rotate(0.0f, yRotation * rotationSpeed, 0.0f);
    }
}