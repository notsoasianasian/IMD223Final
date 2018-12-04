using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveTrigger : MonoBehaviour {
	public GameObject cube1;
    public	Animator anim;

	// Use this for initialization
	void Start () {
		anim = cube1.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)

	{
	
	cube1.GetComponent<Animator>().enabled = true;
	}

	void OnTriggerExit(Collider other)
	{
	cube1.GetComponent<Animator>().enabled = false;
	}
}
