using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour {

	public GameObject[] monsterPrefab;
	public Transform[] monsterSpawnPoints;

	public float minMonsDelay = .1f;
	public float maxMonsDelay = 1f;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(SpawnMonsters());
	}

	IEnumerator SpawnMonsters ()
	{
		
		while (true)
		{
			
			if (GameManager.endGame == false)
			{
				float monsDelay = Random.Range(minMonsDelay, maxMonsDelay);
				yield return new WaitForSeconds(monsDelay);

				int monsterSpawnIndex = Random.Range(0, monsterSpawnPoints.Length);
				Transform monsterSpawnPoint = monsterSpawnPoints[monsterSpawnIndex];

				// Debug.Log(spawnIndex);

				GameObject spawnedMonster = Instantiate(monsterPrefab[UnityEngine.Random.Range(0,monsterPrefab.Length)], monsterSpawnPoint.position, monsterSpawnPoint.rotation);
				Destroy(spawnedMonster, 5f);
				
			} else {

				// Destroy(spawnedMonster);
				break;

			}

			
				
			
		}
	}
	
}
