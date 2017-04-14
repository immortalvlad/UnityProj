using UnityEngine;
using System.Collections;

public class FireProjectTile : MonoBehaviour {

    public string fireButton = "Fire1";
    public Rigidbody projecttile;
    public float force = 100.0f;
    public ForceMode forceMode;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown(fireButton)){
            Rigidbody instance =  Instantiate(projecttile, transform.position, Quaternion.identity) as Rigidbody;
            instance.AddForce(transform.forward * force,forceMode);
        }
	}
}
