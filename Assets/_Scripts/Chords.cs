using UnityEngine;
using System.Collections;

public class Chords : MonoBehaviour {
    
    public float lifespan = 3f;
    public float speed = 250f;
   // public ParticleSystem explosion;
	void Start() {
        GetComponent<Rigidbody>().AddForce(new Vector3(speed * 10f, 0, 0));
        Destroy(gameObject, lifespan);
	}
	
    void OnTriggerEnter(Collider other) {
        if(other.tag == "EnemyChord") {
           // explosion.Play();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
