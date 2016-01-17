using UnityEngine;
using System.Collections;

public class overlayTimeout : MonoBehaviour {
	public float timeout;
	public GameObject sprite;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (sprite, timeout);
	}
}
