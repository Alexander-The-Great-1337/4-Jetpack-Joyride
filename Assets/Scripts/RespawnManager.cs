using System;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;

    [SerializeField] private GameObject floatingObstacle;

    [SerializeField] private float floatingObstacleYPos = 7f;
    
    private readonly float defaultObstacleYPos = 0f;
    private readonly int startDelay = 2;
    private readonly int repeatDelay = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatDelay);
    }

    void SpawnObstacle()
    {
        int index = UnityEngine.Random.Range(0, obstacles.Length);

        Vector3 spawnPos = new(25, GetYPos(index), 0);
        Instantiate(obstacles[index], spawnPos, obstacles[index].transform.rotation);
    }

    private float GetYPos(int index)
    {
        float yPos;

        if (obstacles[index].name == floatingObstacle.name)
        {
            yPos = floatingObstacleYPos;
        }
        else
        {
            yPos = defaultObstacleYPos;
        }

        return yPos;
    }
}
