using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour {

	public Transform Spawnpoint;
	public GameObject Prefab;

	void onTriggerEnter ()
	{
		Instantiate (Prefab, Spawnpoint.position, Spawnpoint.rotation);
	}
}
