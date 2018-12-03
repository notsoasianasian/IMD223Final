using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Vector3 spawnValues;
	public GameObject[] prefab;

	int randPrefab;


	void OnTriggerEnter ()
	{
		randPrefab = Random.Range (0, 3);
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), 1,Random.Range (-spawnValues.z, spawnValues.z));
		Instantiate (prefab[randPrefab], spawnPosition + transform.TransformPoint (0,0,0), gameObject.transform.rotation);
	}
}
