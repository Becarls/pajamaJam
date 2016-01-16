using UnityEngine;
using System.Collections;

public class  shooting : MonoBehaviour {

    public GameObject chord1;
    public GameObject chord2;
    public GameObject chord3;
    public GameObject chord4;
    public GameObject chord5;
    public GameObject chord6;
    public GameObject chord7;
    public float timestamp;
    public float delay;
    public float offset = .5f;
    private float tme;
	void Start() {
        tme = delay;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q)) {  
            if (tme >= delay) {
                Instantiate(chord1.transform, transform.position + new Vector3(offset,0f,0f) , Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            if (tme >= delay) {
                Instantiate(chord2.transform, transform.position + new Vector3(offset, 0f, 0f), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            if (tme >= delay) {
                Instantiate(chord3.transform, transform.position + new Vector3(offset, 0f, 0f), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            if (tme >= delay) {
                Instantiate(chord4.transform, transform.position + new Vector3(offset, 0f, 0f), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            if (tme >= delay) {
                Instantiate(chord5.transform, transform.position + new Vector3(offset, 0, 0), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.F)) {
            if (tme >= delay) {
                Instantiate(chord6.transform, transform.position + new Vector3(offset, 0, 0), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space)) {
            if (tme >= delay) {
                Instantiate(chord7.transform, transform.position + new Vector3(offset, 0, 0), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        tme += Time.deltaTime;
    }
}
