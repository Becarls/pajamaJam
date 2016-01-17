using UnityEngine;
using System.Collections;

public class bossAi : MonoBehaviour {

    public int weakness;
    public float health = 4;
    public int enemyPos = 3;
    public float movement_prob = 40f;
    public AudioSource good;
    public AudioSource bad;
    public AudioSource didDamage;
    public ParticleSystem explosion1;
    public ParticleSystem explosion2;
    public ParticleSystem explosion3;
    public ParticleSystem explosion4;
    public ParticleSystem explosion5;
    public ParticleSystem explosion6;
    public ParticleSystem explosion7;
    private float rand_val;
    private float counter = 0;

    // Use this for initialization
    void Start () {
        rand_val = Random.value;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(counter);
        if (health <= 0)
            Destroy(gameObject);
        rand_val = Random.value;
        //random movement left and right
        if (rand_val >= 1 - (weakness * .1f) / movement_prob) {
            if (enemyPos > 1) {
                this.transform.Translate(new Vector3(0, 0, -4f));
                enemyPos--;
            }
        }
        else if (rand_val <= (weakness * .1f) / movement_prob) {
            if (enemyPos < 4) {
                this.transform.Translate(new Vector3(0, 0, 4f));
                enemyPos++;
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (counter == 0) {
            if (other.tag == "Chord2") {
                good.Play();
                counter++;
                Debug.Log(counter);
                return;
            }
        }
        else if (counter == 1) {
            if (other.tag == "Chord5") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 0;
            }
        }
        else if (counter == 2) {
            if (other.tag == "Chord1") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 0;
            }
        }
        else if (counter == 3) {
            if (other.tag == "Chord6") {
                didDamage.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 0;
            }
        }



        if (counter == 4) {
            if (other.tag == "Chord1") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 4;
            }
        }
        else if (counter == 5) {
            if (other.tag == "Chord2") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 4;
            }
        }
        else if (counter == 6) {
            if (other.tag == "Chord7") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 4;
            }
        }
        else if (counter == 7) {
            if (other.tag == "Chord1") {
                didDamage.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 4;
            }
        }


        if (counter == 8) {
            if (other.tag == "Chord1") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 8;
            }
        }
        else if (counter == 9) {
            if (other.tag == "Chord5") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 8;
            }
        }
        else if (counter == 10) {
            if (other.tag == "Chord4") {
                good.Play();
                counter++;
                return;
            }
            else {
                bad.Play();
                counter = 8;
            }
        }
        else if (counter == 11) {
            if (other.tag == "Chord6") {
                didDamage.Play();
                explosion1.Play();
                explosion2.Play();
                explosion3.Play();
                explosion4.Play();
                explosion5.Play();
                explosion6.Play();
                explosion7.Play();
                Destroy(gameObject);
            }
            else {
                bad.Play();
                counter = 8;
            }
        }
    }
  }

