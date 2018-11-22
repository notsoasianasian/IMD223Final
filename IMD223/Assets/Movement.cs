using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour {

	NavMeshAgent navMeshAgent;
	public float timeForNewPath;
	public bool inCoRoutine = false;


	void Start ()
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}


	void Update ()
	{
		if (!inCoRoutine)
			StartCoroutine (DoSomething);
	}

	Vector3 GetNewRandomPosition ()
	{
		float x = Random.Range (-5, 5);
		float z = Random.Range (-5, 5);

		Vector3 pos = new Vector3 (x, 0, z);
	}

	IEnumerator DoSomething ()

	{
		inCoRoutine = true;
		yield return new WaitForSeconds (timeForNewPath);
		GetNewPath();
		inCoRoutine = false;
	}

	void GetNewPath ()

	{
		navMeshAgent.SetDestination (GetNewRandomPosition ());	
	}

}
