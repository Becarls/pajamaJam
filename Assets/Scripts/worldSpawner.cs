using UnityEngine;
using System.Collections;

public class worldSpawner : MonoBehaviour {

	public GameObject gameObj;

	public float xDir;
	public float yDir;
	public float zDir;
	public float x;
	public float y;
	public float z;

	void Start () {
		StartCoroutine(SpawnShit());
	}
	
	IEnumerator SpawnShit () {

		while (true) {
			Vector3 spawnPosition = new Vector3(x, y, z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(gameObj, spawnPosition, spawnRotation);
			GetComponent<Rigidbody> ().transform.Translate(xDir, yDir, zDir);
		}
	}
}