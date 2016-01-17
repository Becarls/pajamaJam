using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {
	public Rigidbody rigidCube;
	public int playerPos = 1;
	public float movementSpeed = 2;
	public float movementTime = 2;
	public bool isMoving = false;
    public int health = 4;
	public int roadSize = 2000;
    public AudioSource hurt;

	void Start () {
		rigidCube = this.GetComponent<Rigidbody>();
        gameObject.GetComponent<AudioSource>().Play();
	}

	void Update () {
        if(health <= 0) {
            //DIE MOTHERFUCKER
        }
        //transform.Translate(new Vector3(0,Mathf.Sin(Time.time * 40f), 0));
        if (isMoving) {
		}else{
			if(Input.GetKeyDown(KeyCode.LeftArrow)){
				if (playerPos == 0) {
				}else{
					playerPos--;
					this.transform.Translate(new Vector3(-4,0,0 * movementTime * movementSpeed));
				}
			}

			if(Input.GetKeyDown(KeyCode.RightArrow)){
				if (playerPos == 3) {
				}else{
				playerPos++;
				this.transform.Translate(new Vector3(4, 0, 0 * movementTime * movementSpeed));
				}
			}
		}
	}

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy" || other.tag == "EnemyChord") {
            health--;
            hurt.Play();
        }
    }
}
