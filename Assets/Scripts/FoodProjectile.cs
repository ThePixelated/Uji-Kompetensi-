using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodProjectile : MonoBehaviour
{
    [SerializeField] float _projectileSpeed = 300;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SpawnFood(Transform pivotLocation)
    {
        Debug.Log("Lempar Makanan");
        var foodObject = Instantiate(gameObject, pivotLocation.transform.position, Quaternion.identity);
        var foodVelocity = foodObject.GetComponent<Rigidbody>();

        if (foodVelocity != null)
            foodVelocity.velocity = new Vector3(0f, 0f, _projectileSpeed * Time.deltaTime);
    }
}
