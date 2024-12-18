using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public delegate void PlayerControllerDelegate();

    private PlayerControllerDelegate _playerControls;

    private void Start()
    {
        Debug.Log("Test");

        _playerControls += Movement;
        _playerControls += Controller;
    }

    void Update()
    {
        _playerControls();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))     // Key bind ke kiri
        {
            Debug.Log("Go to the left");
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))    // Key bind ke kanan
        {
            Debug.Log("Go to the right");
        }
    }

    private void Controller()
    {
        if (Input.GetKey(KeyCode.Escape))     // ESC pause menu
        {
            Debug.Log("Escape Pressed");
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))    // Lempar Makanan
        {
            Debug.Log("Lempar Makanan");
        }
    }
}
