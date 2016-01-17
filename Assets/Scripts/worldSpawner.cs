using UnityEngine;
using System.Collections;

public class worldSpawner : MonoBehaviour {

	public GameObject gameObj;

	public float x;
	public float y;
	public float z;

	public float wait;


	void Start () {
		StartCoroutine(SpawnShit());
	}

	IEnumerator SpawnShit () {
		while (true) {

			Vector3 spawnPosition = new Vector3(x, y, z);
			Quaternion spawnRotation = Quaternion.identity;
			GameObject obj = (GameObject) Instantiate (gameObj, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (wait);
		}
	}
}
