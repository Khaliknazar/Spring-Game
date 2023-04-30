using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] ScoreController scoreController;
    [SerializeField] GameObject[] obstaclePrefabs;
    [SerializeField] float waitSeconds1;
    [SerializeField] float waitSeconds2;
    [SerializeField] Vector2 spawnPosition;

    bool isDone = false;
    Coroutine SpawningEasy;
    void Start()
    {
        SpawningEasy = StartCoroutine(ObstacleSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreController.score > 250f && !isDone)
        {
            waitSeconds1 = 1.4f;
            waitSeconds2 = 2.0f;
            isDone = true;
        }
    }

    IEnumerator ObstacleSpawning()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(waitSeconds1, waitSeconds2));
            Instantiate(obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)], spawnPosition, Quaternion.identity);
        }
    }
}
