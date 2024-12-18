using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private float _score;

    public float GetScore()
    {
        return _score;
    }

    public void AddScore(float amount)
    {
        _score += amount;
    }

    public void SubtractScore(float amount)
    {
        _score -= amount;
    }
}
