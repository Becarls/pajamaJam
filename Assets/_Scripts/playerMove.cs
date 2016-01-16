using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {
	public Rigidbody rigidCube;
	public int playerPos = 1;
	public float movementSpeed = 2;
	public bool isMoving = false;
	// Use this for initialization
	void Start () {
		rigidCube = this.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (isMoving) {
		}else{
			if(Input.GetKey(KeyCode.LeftArrow)){
				playerPos--;
				this.transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime * movementSpeed));
			}

			if(Input.GetKey(KeyCode.RightArrow)){
				playerPos++;
				this.transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * movementSpeed));
			}
		}
	}
}
