using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyToShoot;
    public float interval;
    public float maxX;
    public float minX;
    public GameObject startEnemyLine;

    private IEnumerator SpawnEnemy(float t)
    {
        while (true)
        {
            yield return new WaitForSeconds(t);
            GameObject enemy = Instantiate(enemyToShoot);
            float randomPos = Random.Range(minX, maxX);
            enemy.transform.position = new Vector2(randomPos, startEnemyLine.transform.position.y);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnEnemy(interval));
    }
}
