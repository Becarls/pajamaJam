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
<<<<<<< HEAD
			Vector3 spawnPosition = new Vector3(x, y, z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(gameObj, spawnPosition, spawnRotation);
			GetComponent<Rigidbody> ().transform.Translate(xDir, yDir, zDir);
		}
=======
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
>>>>>>> 44151c9958398f6c987590e84912016e880f7d34
	}
}