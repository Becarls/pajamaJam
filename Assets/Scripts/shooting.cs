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
    public AudioSource clip1;
    public AudioSource clip2;
    public AudioSource clip3;
    public AudioSource clip4;
    public AudioSource clip5;
    public AudioSource clip6;
    public AudioSource clip7;
    public float delay;
    public float offset = .5f;
    private float tme;
    private float timestamp;
    void Start() {
        tme = delay;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {  
            if (tme >= delay) {
                clip1.Play();
                Instantiate(chord1.transform, transform.position + new Vector3(offset,0f,0f) , Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            if (tme >= delay) {
                clip2.Play();
                Instantiate(chord2.transform, transform.position + new Vector3(offset, 0f, 0f), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            if (tme >= delay) {
                clip3.Play();
                Instantiate(chord3.transform, transform.position + new Vector3(offset, 0f, 0f), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R)) {
            if (tme >= delay) {
                clip4.Play();
                Instantiate(chord4.transform, transform.position + new Vector3(offset, 0f, 0f), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            if (tme >= delay) {
                clip5.Play();
                Instantiate(chord5.transform, transform.position + new Vector3(offset, 0, 0), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.F)) {
            if (tme >= delay) {
                clip6.Play();
                Instantiate(chord6.transform, transform.position + new Vector3(offset, 0, 0), Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q)) {
            if (tme >= delay) {
                clip7.Play();
                Instantiate(chord7.transform, transform.position + new Vector3(offset, 0, 0), Quaternion.Euler(0, 0, 90f));
                tme = 0;
                clip7.Play();
            }
        }
        tme += Time.deltaTime;
    }
}
