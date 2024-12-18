using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerDisplay;
    [SerializeField] private Timer _timer;

    // Start is called before the first frame update
    void Start()
    {
        _timerDisplay.text = ((int)_timer.GetTimerValue()).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _timerDisplay.text = ((int)_timer.GetTimerValue()).ToString();
    }
}
