using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timer = 60f;
    private void Update()
    {
        if (!isTimeOver())
        {
            _timer -= Time.deltaTime;
        }
    }

    public float GetTimerValue()
    {
        return _timer;
    }

    public bool isTimeOver()
    {
        return _timer < 0;
    }

}
