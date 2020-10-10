using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour {

	public GameObject humanPrefab;
	public Transform[] humanSpawnPoints;

	public float minHumanDelay = 4f;
	public float maxHumanDelay = 8f;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnHumans());
	}

	IEnumerator SpawnHumans ()
	{
		
		// be careful must always rmb to put delay
		while (true)
		{
			
			if (GameManager.endGame == false)
			{
				float humanDelay = Random.Range(minHumanDelay, maxHumanDelay);
				yield return new WaitForSeconds(humanDelay);

				int humanSpawnIndex = Random.Range(0, humanSpawnPoints.Length);
				Transform humanSpawnPoint = humanSpawnPoints[humanSpawnIndex];

				// Debug.Log(spawnIndex);

				GameObject spawnedHuman = Instantiate(humanPrefab, humanSpawnPoint.position, humanSpawnPoint.rotation);
				Destroy(spawnedHuman, 5f);
				
			} else {

				// Destroy(spawnedHuman);
				break;

			}
			
			
			

		}
						
		

	}
	
}
