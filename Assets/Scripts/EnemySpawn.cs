using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemyPrefabs;
    [SerializeField] private List<float> _enemysSpeed = new List<float>(){ 250f, 300f, 350f, 150f };

    [SerializeField] private Timer _timer;
    [SerializeField] private bool spawnEnable;

    private void Start()
    {
        spawnEnable = true;
    }

    void Update()
    {
        if (!_timer.isTimeOver() && spawnEnable)
        {
            Debug.Log("Spawn enemy");
            spawnEnable = false;
            SpawningEnemy();
            StartCoroutine(WaitTime(2));
        }
    }

    private IEnumerator WaitTime(float timeInterval)
    {
        yield return new WaitForSeconds(timeInterval);

        spawnEnable = true;
    }

    private void SpawningEnemy()
    {
        var randomEnemyIndex = Random.Range(0, 4);
        var spawnEnemyType = _enemyPrefabs[randomEnemyIndex];

        var randomX_pos = (int)Random.Range(-14f, 14f);
        var enemyObject = Instantiate(_enemyPrefabs[randomEnemyIndex], new Vector3(randomX_pos, 1.17f, 18f), Quaternion.identity);
        
        var enemyVelocity = enemyObject.GetComponent<Rigidbody>();
        if (enemyVelocity != null)
            enemyVelocity.velocity = new Vector3(0f, 0f, _enemysSpeed[randomEnemyIndex] * Time.deltaTime * -1);
    }
}
