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
    public bool tree = false;

	void Start () {
		StartCoroutine(SpawnShit());

	}
	
	IEnumerator SpawnShit () {
		yield return new WaitForSeconds(startWait);

		while (true) {
<<<<<<< HEAD

=======
>>>>>>> acdc8cad9ac1c2751290d0eb31adad8f4ded56db
            float z_value = Random.Range(position1, position1end);
            if (tree) {
                z_value = spawnValues.z;
            }
			Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, z_value);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(tree1, spawnPosition, spawnRotation);
			//tree1.GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0, 0));
			yield return new WaitForSeconds(spawnWait);
			}
<<<<<<< HEAD

=======
>>>>>>> acdc8cad9ac1c2751290d0eb31adad8f4ded56db
	}
}