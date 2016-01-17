using UnityEngine;
using System.Collections;

public class titleMove: MonoBehaviour {

	public GameObject title;

	public float x;
	public float y;
	public float z;
	public float speed;
	public float timeOut = 5;

	// Use this for initialization
	void Start () {
		StartCoroutine (TitleMove ());
	}
	
	// Update is called once per frame
	IEnumerator TitleMove() {
		while (true) {
			GetComponent<TextMesh> ().transform.Translate (new Vector3 (x, y, z) * Time.deltaTime * speed);
			Destroy (title, timeOut);
			yield return new WaitForSeconds(0);
		}
	}
}
