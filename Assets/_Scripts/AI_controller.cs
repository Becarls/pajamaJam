using UnityEngine;
using System.Collections;

public class AI_controller : MonoBehaviour {

    public float health = 5;
    public float movementSpeed = 2;
    public float movementTime = 2;
    public int enemyPos = 3;
    private float weakness;
    private float rand_val;

	void Start () {
        rand_val = Random.value;
        weakness = (100f * rand_val) % 7f;
	}
	
	// Update is called once per frame
	void Update () {
        rand_val = Random.value;
        if(rand_val > 1 -(weakness * .1f) / 50f) {
            if (enemyPos > 1) {
                this.transform.Translate(new Vector3(0, 0, -1 * movementTime * movementSpeed));
                enemyPos--;
            }
        }
        else if (rand_val < (weakness * .1f) / 50f) {
            if (enemyPos < 4) {
                this.transform.Translate(new Vector3(0, 0, 1 * movementTime * movementSpeed));
                enemyPos++;
            }
        }
    }
}
