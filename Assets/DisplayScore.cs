using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private ScoreSystem _scoreSystem;
    [SerializeField] private TextMeshProUGUI _scoreRunTime;


    // Start is called before the first frame update
    void Start()
    {
        _scoreRunTime.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        _scoreRunTime.text = ((int)_scoreSystem.GetScore()).ToString();
    }
}
