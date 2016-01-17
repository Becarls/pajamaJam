using UnityEngine;
using System.Collections;

public class AI_controller : MonoBehaviour {

    public float health = 5;
    public float speed = 50f;
    public float movementSpeed = 2;
    public float movementTime = 2;
    public int enemyPos = 3;
    public float delay;
    public float offset = -2f;
    public GameObject enemyChord;
    public float movement_prob = 40f;
    public int weakness;
    public int type;
    public float wobbleSpeed = .01f;

    private string tag_resist;
    private string tag_strong;
    private float rand_val;
    private float tme;
    private float timestamp;

    void Start () {
        tme = delay;
        rand_val = Random.value;
        weakness = (int)Mathf.Ceil((100f * rand_val) % 7f);
        GetComponent<Rigidbody>().AddForce(new Vector3(-speed, 0, 0));
        if(gameObject.transform.position.z == -6) {
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
         switch (type) {
             case 1:
                 tag_strong = "Chord1";
                 tag_resist = "Chord2";
                 break;
             case 2:
                 tag_strong = "Chord2";
                 tag_resist = "Chord3";
                 break;
             case 3:
                 tag_strong = "Chord3";
                 tag_resist = "Chord4";
                 break;
             case 4:
                 tag_strong = "Chord4";
                 tag_resist = "Chord5";
                 break;
             case 5:
                 tag_strong = "Chord5";
                 tag_resist = "Chord6";
                 break;
             case 6:
                 tag_strong = "Chord6";
                 tag_resist = "Chord7";
                 break;
             case 7:
                 tag_strong = "Chord7";
                 tag_resist = "Chord1";
                 break;
         }
    }
	
	// Update is called once per frame
	void Update () {
       // transform.rotation = Quaternion.Euler (0,0,Mathf.Sin(Time.time * wobbleSpeed));
        if (health <= 0)
            Destroy(gameObject);
        rand_val = Random.value;
        //random movement left and right
        if(rand_val >= 1 -(weakness * .1f) / movement_prob) {
            if (enemyPos > 1) {
                this.transform.Translate(new Vector3(0, 0, -1 * movementTime * movementSpeed));
                enemyPos--;
            }
        }
        else if (rand_val <= (weakness * .1f) / movement_prob) {
            if (enemyPos < 4) {
                this.transform.Translate(new Vector3(0, 0, 1 * movementTime * movementSpeed));
                enemyPos++;
            }
        }

        //random shoot
        if(rand_val < .01 / weakness && tme >= delay) {
            Instantiate(enemyChord.transform, transform.position + new Vector3(offset, 0f, 0f), Quaternion.Euler(0, 0, 0f));
            tme = 0;
        }
        tme += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other) {
        
        if(other.tag == tag_strong) {
            Destroy(other);
            gameObject.GetComponent<AudioSource>().Play();
            health -= 3;
        }
        else if(other.tag == tag_resist) {
            Destroy(other);
            gameObject.GetComponent<AudioSource>().Play();
            health -= 1;
        }
        else if(other.tag == "Chord1" ||
                other.tag == "Chord2" ||
                other.tag == "Chord3" ||
                other.tag == "Chord4" ||
                other.tag == "Chord5" ||
                other.tag == "Chord6" ||
                other.tag == "Chord7") {
            Destroy(other);
            gameObject.GetComponent<AudioSource>().Play();
            health -= 2;
        }
        else if (other.tag == "EnemyChord") {
        }
    }

}
