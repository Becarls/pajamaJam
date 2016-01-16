using UnityEngine;
using System.Collections;

public class Chords : MonoBehaviour {
    
    public float lifespan = 3f;
    public float speed = 25f;
	void Start() {
        GetComponent<Rigidbody>().AddForce(new Vector3(speed * -10f, 0, 0));
        Destroy(gameObject, lifespan);
	}
	
}
