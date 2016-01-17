using UnityEngine;
using System.Collections;

public class floorMove : MonoBehaviour {

	public float xDir;
	public float yDir;
	public float zDir;
    public float lifespan;
    public float speed;

	void Start() { 
        Destroy(gameObject, lifespan);
    }

    void Update() {
		transform.Translate (new Vector3(xDir, yDir, zDir) * Time.deltaTime * speed);
    }
}
