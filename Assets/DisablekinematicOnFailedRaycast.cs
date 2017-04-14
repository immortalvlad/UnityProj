using UnityEngine;
using System.Collections;

public class DisablekinematicOnFailedRaycast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!Physics.Raycast(transform.position, -transform.up, transform.localScale.y)) {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().WakeUp();
        }
	}
}
