using UnityEngine;
using System.Collections;

public class  shooting : MonoBehaviour {

    public GameObject chord1;
    /* public GameObject chord2;
     public GameObject chord3;
     public GameObject chord4;
     public GameObject chord5;
     public GameObject chord6;
     public GameObject chord7;*/
    public float timestamp;
    public float delay;
    private float tme;

	void Start() {
        tme = delay;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q)) {  
            if (tme >= delay) {
                Instantiate(chord1.transform, transform.position , Quaternion.Euler(0, 0, 90f));
                tme = 0;
            }
        }
        tme += Time.deltaTime;
    }
}
