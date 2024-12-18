using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public delegate void PlayerControllerDelegate();

    //private PlayerControllerDelegate _playerDelegate;
    [SerializeField] private float _playSpeed = 350f;
    [SerializeField] private FoodProjectile _foodProjectile;
    [SerializeField] private Transform _throwPivot;
    private Rigidbody _rb;
    private bool isPauseFlag;

    private void Start()
    {
        Debug.Log("Test");

        //_playerDelegate += PlayerControls;
        //_playerDelegate += Controller;

        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!IsPause())
        {
            //_playerDelegate();
            PlayerControls();
            Controller();
        } else
        {
            //_playerDelegate();
            Controller();
        }
    }

    private void PlayerControls()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))     // Key bind ke kiri
        {
            Debug.Log("Left key");
            _rb.velocity = new Vector3(_playSpeed * Time.deltaTime * -1, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))    // Key bind ke kanan
        {
            Debug.Log("Right key");
            _rb.velocity = new Vector3(_playSpeed * Time.deltaTime, 0f, 0f);
        }
        else
        {
            _rb.velocity = new Vector3(0, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))    // Lempar Makanan
        {
            _foodProjectile.SpawnFood(_throwPivot);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Lempar Makanan - Mouse");
        }
    }

    private void Controller()
    {
        if (Input.GetKeyDown(KeyCode.Escape))     // ESC pause menu
        {
            isPauseFlag = !isPauseFlag;
        }
    }

    private bool IsPause()
    {
        if (isPauseFlag)
        {
            //Debug.Log("Pause Enable");
            Time.timeScale = 0;
            //_playerDelegate -= PlayerControls;

            // Activate Pause Menu

            return true;
        }
        else
        {
            //Debug.Log("Pause Disable");
            Time.timeScale = 1;
            //_playerDelegate += PlayerControls;

            return false;
        }
    }
}
