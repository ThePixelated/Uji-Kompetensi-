using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private ScoreSystem _scoreSystem;
    private Animation anim;

    private void Start()
    {
        anim = GetComponent<Animation>();

        _scoreSystem = GameObject.Find("ScoreManager").GetComponent<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("DestroyBarrier"))
        {
            _scoreSystem.SubtractScore(3);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
