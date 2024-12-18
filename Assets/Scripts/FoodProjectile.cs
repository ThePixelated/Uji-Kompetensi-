using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodProjectile : MonoBehaviour
{
    [SerializeField] float _projectileSpeed = 300;
    private ScoreSystem _scoreSystem;

    private void Start()
    {
        _scoreSystem = GameObject.Find("ScoreManager").GetComponent<ScoreSystem>();
    }

    public void SpawnFood(Transform pivotLocation)
    {
        Debug.Log("Lempar Makanan");
        var foodObject = Instantiate(gameObject, pivotLocation.transform.position, Quaternion.identity);
        var foodVelocity = foodObject.GetComponent<Rigidbody>();

        if (foodVelocity != null)
            foodVelocity.velocity = new Vector3(0f, 0f, _projectileSpeed * Time.deltaTime);

        //Destroy(gameObject, 3f);
    }

    public void DestroyFood(float waitTime)
    {
        Destroy(gameObject, waitTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {

            _scoreSystem.AddScore(1);
            Destroy(gameObject);
        }
    }
}
