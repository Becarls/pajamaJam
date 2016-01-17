using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

    public float gameLength = 90f;
    public GameObject spawner;
    public GameObject boss;
    private float gameTime = 0f;
    // Use this for initialization
    void Start() {
        gameDriver();
    }

    // Update is called once per frame
    void Update() {
        gameTime += (Time.deltaTime);
    }

    IEnumerator gameDriver() {
        Debug.Log(gameTime);
        yield return new WaitForSeconds(gameLength);
        Debug.Log("hello");
        Destroy(spawner);
        yield return new WaitForSeconds(5f);
        Instantiate(boss, new Vector3(-2, 19, -9), Quaternion.identity);
    }
}
