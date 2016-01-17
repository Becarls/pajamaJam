using UnityEngine;
using System.Collections;

public class spawnerLogic : MonoBehaviour {
    public GameObject hazard;
    public Vector3 spawnValues;
    public int[] z_array = new int[] { -6, -2, 2, 6 };
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float levelupTime = 300f;
    private float tme = 0;

    void Start() {
        StartCoroutine(SpawnWaves());
    }

    void Update() {
        tme += Time.deltaTime;
        if(tme >= levelupTime) {
            if(hazardCount < 14)
                hazardCount++;
            if(waveWait > 0)
                waveWait--;
            tme = 0;
        }
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

