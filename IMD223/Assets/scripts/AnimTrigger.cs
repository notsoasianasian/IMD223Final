using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour {

	public Animator TargetAnimator = null;
	public string TriggerName = string.Empty;

	void OnTriggerEnter (Collider other)
	{
		TargetAnimator.SetTrigger (TriggerName);
	}
}

