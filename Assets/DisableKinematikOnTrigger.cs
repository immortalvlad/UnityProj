using UnityEngine;
using System.Collections;

public class DisableKinematikOnTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Rigidbody>())
        {
            col.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
