using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rando : MonoBehaviour {

	public GameObject Prefab;
	public Vector3 center;
	//public Vector3 size;


	void Update ()
	{
	//	if (Input.GetKey (KeyCode.Q))
	//		SpawnIt ();
	}
	public void SpawnIt ()
	{
		Vector3 pos = center + new Vector3(Random.Range(0,10),Random.Range(0,10));

		Instantiate (Prefab, pos, Quaternion.identity);
	}

	//void OnDrawGizmosSelected ()
	//{
	//	Gizmos.color = new Color(1,0,0,0.5f);
	//		Gizmos.DrawCube(transform.localPosition + center,size);

	//}

	void OnTriggerEnter(Collider other)
	{
		SpawnIt ();
		
	}
}
