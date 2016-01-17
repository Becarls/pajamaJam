using UnityEngine;
using System.Collections;

public class bossBattle : MonoBehaviour {

    public float health = 4f;
    public float movement_prob = 40f;
    public float enemyPos;
    public float weakness = 6.4f;
    public AudioSource good;
    public AudioSource bad;
    public AudioSource didDmg;
    private int counter = 0;
    private float rand_val;
    // Use this for initialization
    void Start() {
         GetComponent<Renderer>().material.color = Color.white;
        if (gameObject.transform.position.z == -6) {
            enemyPos = 1;
        }
        else if (gameObject.transform.position.z == -2) {
            enemyPos = 2;
        }
        else if (gameObject.transform.position.z == 2) {
            enemyPos = 3;
        }
        else if (gameObject.transform.position.z == 6) {
            enemyPos = 4;
        }
    }

    void Update() {
        if (health <= 0)
            Destroy(gameObject);
        rand_val = Random.value;
        //random movement left and right
        if (rand_val >= 1 - (weakness * .1f) / movement_prob) {
            if (enemyPos > 1) {
                this.transform.Translate(new Vector3(0, 0, -1 * 4f));
                enemyPos--;
            }
        }
        else if (rand_val <= (weakness * .1f) / movement_prob) {
            if (enemyPos < 4) {
                this.transform.Translate(new Vector3(0, 0, 1 * 4f));
                enemyPos++;
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if(counter == 0) {
            if(other.tag == "Chord2") {
                good.Play();
                 GetComponent<Renderer>().material.color = Color.cyan;
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 0;
                GetComponent<Renderer>().material.color = Color.white;
            }
        }
        else if (counter == 1) {
            if (other.tag == "Chord5") {
                good.Play();
                 GetComponent<Renderer>().material.color = Color.red;
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 0;
                 GetComponent<Renderer>().material.color = Color.white;
            }
        }
       else if (counter == 2) {
            if (other.tag == "Chord1") {
                good.Play();
                 GetComponent<Renderer>().material.color = Color.magenta;
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 0;
                 GetComponent<Renderer>().material.color = Color.white;
            }
        }
       else if (counter == 3) {
            if (other.tag == "Chord6") {
                didDmg.Play();
                 GetComponent<Renderer>().material.color = Color.red;
                counter++;
                health--;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 0;
                 GetComponent<Renderer>().material.color = Color.white;
            }
        }



       else if (counter == 4) {
            if (other.tag == "Chord1") {
                good.Play();
                counter++;
                 GetComponent<Renderer>().material.color = Color.white;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 4;
                 GetComponent<Renderer>().material.color = Color.red;
            }
        }
       else if (counter == 5) {
            if (other.tag == "Chord2") {
                 GetComponent<Renderer>().material.color = Color.grey;
                good.Play();
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 4;
                 GetComponent<Renderer>().material.color = Color.red;
            }
        }
        else if (counter == 6) {
            if (other.tag == "Chord7") {
                 GetComponent<Renderer>().material.color = Color.red;
                good.Play();
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 4;
                 GetComponent<Renderer>().material.color = Color.red;
            }
        }
       else if (counter == 7) {
            if (other.tag == "Chord1") {
                didDmg.Play();
                 GetComponent<Renderer>().material.color = Color.red;
                counter++;
                health--;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 4;
                 GetComponent<Renderer>().material.color = Color.red;
            }
        }


        else if (counter == 8) {
            if (other.tag == "Chord1") {
                 GetComponent<Renderer>().material.color = Color.cyan;
                good.Play();
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                 GetComponent<Renderer>().material.color = Color.red;
                bad.Play();
                counter = 8;
            }
        }
       else  if (counter == 9) {
            if (other.tag == "Chord5") {
                 GetComponent<Renderer>().material.color = Color.yellow;
                good.Play();
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                counter = 8;
                 GetComponent<Renderer>().material.color = Color.red;
            }
        }
        else if (counter == 10) {
            if (other.tag == "Chord4") {
                 GetComponent<Renderer>().material.color = Color.magenta;
                good.Play();
                counter++;
            }
            else if (other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                 GetComponent<Renderer>().material.color = Color.red;
                counter = 8;
            }
        }
        else if (counter == 11) {
            if (other.tag == "Chord6") {
                 GetComponent<Renderer>().material.color = Color.black;
                didDmg.Play();
                counter++;
                health--;
            }
            else if(other.tag != "Enemy" || other.tag != "EnemyChord") {
                bad.Play();
                 GetComponent<Renderer>().material.color = Color.red;
                counter = 4;
            }
        }

    }
}
