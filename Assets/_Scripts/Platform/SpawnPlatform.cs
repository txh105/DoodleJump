using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;

    [SerializeField] private int numberOfPlatforms = 20;
    [SerializeField] private float levelWidth = 2f;
    [SerializeField] private float minY = 0.2f;
    [SerializeField] private float maxY = 1.5f;

    [SerializeField] private float distancePlatform;

    // Use this for initialization
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}