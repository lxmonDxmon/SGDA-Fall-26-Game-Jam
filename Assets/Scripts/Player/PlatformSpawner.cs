using UnityEngine;

public class PlatformSpawner : MonoBehaviour {
    [SerializeField] private Platform platformPrefab;
    private int platformsSpawned;
    [SerializeField] private int numPlatforms;

    private void Awake() {
        platformsSpawned = 0;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.LeftShift) && platformsSpawned < numPlatforms) {
            Platform platInstance = Instantiate(platformPrefab, transform.position, Quaternion.identity);

            platInstance.Spawn();
            platformsSpawned++;
        }
    }
}
