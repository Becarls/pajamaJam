using UnityEngine;
using System.Collections;

public class despawner : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy"){
            Destroy(other);
        }
    }
}
