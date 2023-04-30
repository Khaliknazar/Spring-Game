using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefabs;
    [SerializeField] float waitSeconds1;
    [SerializeField] float waitSeconds2;
    [SerializeField] Vector2 spawnPosition;
    Coroutine SpawningEasy;
    void Start()
    {
        SpawningEasy = StartCoroutine(ObstacleSpawning());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ObstacleSpawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(waitSeconds1, waitSeconds2));
            Instantiate(obstaclePrefabs[Random.Range(0, 2)], spawnPosition, Quaternion.identity);
        }
    }
}
