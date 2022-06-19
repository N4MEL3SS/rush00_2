using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerManager : MonoBehaviour
{
    public GameObject[] spawnerPointsMassive;
    public GameObject[] enemyPrefabs;

    public float[] spawnerDirection;

    private void Spawn()
    {
        for(var k = 0; k < spawnerPointsMassive.Length; k++)
        {
            Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], spawnerPointsMassive[k].transform.position, Quaternion.identity);
            
        }
    }
}
