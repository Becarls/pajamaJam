using UnityEngine;
using System.Collections;

public class spawnerLogic : MonoBehaviour {
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
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
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, z_value);
                Quaternion spawnRotation = Quaternion.identity;
                int rand = Random.Range(1, 8);
                switch (rand) {
                    case 1:
                        Instantiate(enemy1, spawnPosition, spawnRotation);
                        break;
                    case 2:
                        Instantiate(enemy2, spawnPosition, spawnRotation);
                        break;
                    case 3:
                        Instantiate(enemy3, spawnPosition, spawnRotation);
                        break;
                    case 4:
                        Instantiate(enemy4, spawnPosition, spawnRotation);
                        break;
                    case 5:
                        Instantiate(enemy5, spawnPosition, spawnRotation);
                        break;
                    case 6:
                        Instantiate(enemy6, spawnPosition, spawnRotation);
                        break;
                    case 7:
                        Instantiate(enemy7, spawnPosition, spawnRotation);
                        break;
                }
                yield return new WaitForSeconds(spawnWait);
            }
            hazardCount++;
            yield return new WaitForSeconds(waveWait);
        }
    }
}

