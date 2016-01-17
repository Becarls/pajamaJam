using UnityEngine;
using System.Collections;

public class floorMove : MonoBehaviour {

    // Use this for initialization
    public float lifespan = 3f;
    public float speed = 250f;
    // public ParticleSystem explosion;
    void Start() { 
        Destroy(gameObject, lifespan);
    }

    void Update() {
        transform.Translate(speed * Time.deltaTime,0,0);
    }
}
