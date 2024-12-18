using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [SerializeField] List<GameObject> cameras;
    [SerializeField] Timer timer;

    private void Start()
    {
        cameras[0].SetActive(true);
        cameras[1].SetActive(false);
    }

    private void Update()
    {
        if (timer.isTimeOver())
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
        }
    }
}
