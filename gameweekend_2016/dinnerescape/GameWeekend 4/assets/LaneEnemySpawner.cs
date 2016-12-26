using UnityEngine;
using System.Collections;

public class LaneEnemySpawner : MonoBehaviour {

    public bool canSpawn = false;
    public int devCount = 0;
    public int[] spawnIntervals = new int[] { 0,3,4,2,1,5 };
    public GameObject[] lanes;
    public GameObject[] enemys;
    public float lastSpawn = 0;

    void Start()
    {
        lastSpawn = Time.time + 100;
    }
    void SpawnJob(int lane)
    {
        Object obj = Instantiate(enemys[Random.Range(0, enemys.Length)]);
        ((GameObject)obj).transform.position = lanes[lane].transform.position + new Vector3(15,0,0);
        devCount++;
        lastSpawn = Time.time;
    }
    void Update()
    {
        for(int i = 0; i < lanes.Length; i++)
        {
            GameObject lane = lanes[i];
            if(Time.time + spawnIntervals[devCount % spawnIntervals.Length] <= lastSpawn)
            {
                SpawnJob(i);
            }
        }
    }
}
