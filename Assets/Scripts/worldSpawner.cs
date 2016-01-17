using UnityEngine;
using System.Collections;

public class worldSpawner : MonoBehaviour {

	public GameObject tree1;

	public float speed;

	public float position1;
	public float position1end;

	public float spawnWait;
	public float startWait;
	public float waveWait;

	public Vector3 spawnValues;


	void Start () {
		StartCoroutine(SpawnShit());

	}
	
	IEnumerator SpawnShit () {
		yield return new WaitForSeconds(startWait);

		while (true) {
				float z_value = Random.Range(position1, position1end);
				Debug.Log(z_value);
				Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, z_value);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate(tree1, spawnPosition, spawnRotation);
			tree1.GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0, 0));
				yield return new WaitForSeconds(spawnWait);
			}
	}
}