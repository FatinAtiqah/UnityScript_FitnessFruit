using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public int enemiesCount;
    public float spawnWait;
    public float waveWait;
	// Use this for initialization
	void Start ()
    {
        spawnWait = Random.Range(1f, 6f);
        StartCoroutine(SpawnWaves());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds(spawnWait);
        while (true)
        {
            for (int i = 0; i < enemiesCount; i++)
            { 
               GameObject obj = Instantiate(enemies [Random.Range(0,enemies.Length)],transform.position, Quaternion.identity ) as GameObject;
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
