using UnityEngine;
using System.Collections;

public class wobble : MonoBehaviour {
    public float wobbleSpeed = 25f;
    void Update() {
        transform.rotation = Quaternion.Euler(0, 90, Mathf.Sin(Time.time * wobbleSpeed));
    }
}
