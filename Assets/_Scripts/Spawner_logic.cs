using UnityEngine;
using System.Collections;

public class Spawner_logic : MonoBehaviour {
    public GameObject hazard;
    public Vector3 spawnValues;
    public int[] z_array = new int[] { -6, -2, 2, 6 };
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start() {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves() {
        yield return new WaitForSeconds(startWait);
        while (true) {
            for (int i = 0; i < hazardCount; i++) {
                float z_value = z_array[Random.Range(0, 4)];
                Debug.Log(z_value);
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, z_value);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}

