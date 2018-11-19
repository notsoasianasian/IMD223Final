using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour {

	public Color[] colorBank;
	public bool mesh;

	// Use this for initialization
	void Start () {

		int Num = Random.Range (0, colorBank.Length);

		if (mesh) {
			MeshRenderer m = GetComponent<MeshRenderer> ();
			m.material.color = colorBank [Num];
		}
	}
	void onColliderEnter(Collider other)
		{
		other.GetComponent<MeshRenderer> ();
		}

	}


