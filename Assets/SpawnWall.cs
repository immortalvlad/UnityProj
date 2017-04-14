using UnityEngine;
using System.Collections;

public class SpawnWall : MonoBehaviour {

    public int width = 10;
    public int height = 10;
    public Rigidbody wallChunk;
    private float offset = 0.1f;
    private float chunkWidth;
    private float chunkHeight;

	// Use this for initialization
	void Start () {

        chunkWidth = wallChunk.transform.localScale.x;
        chunkHeight = wallChunk.transform.localScale.y;

        
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++){
                float staggerOffset = 0.0f;
                if (y % 2 == 0) {
                    staggerOffset = chunkWidth  /2.0f;
                }
                Rigidbody insance = Instantiate(wallChunk, transform.position + x*(transform.right*(chunkWidth)) +y*(transform.up*(chunkHeight + offset)) + transform.right*staggerOffset, Quaternion.identity) as Rigidbody;
                insance.isKinematic = true;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
