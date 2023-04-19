using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObject : MonoBehaviour
{
    [SerializeField] GameObject spawnBullet;
    Transform spawnPoint;
    [SerializeField] Transform gunTile;
    float time;
    void Start()
    {
        spawnPoint = transform.GetChild(3);
        time = 0;
    }
    void Update()
    {
        if (time >= 2f)
        {
            Spawn();
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
    }
    void Spawn()
    {
        GameObject amount = Instantiate(spawnBullet, spawnPoint.position, Quaternion.identity, gunTile);
        Destroy(amount, 2.5f);
    }
}
