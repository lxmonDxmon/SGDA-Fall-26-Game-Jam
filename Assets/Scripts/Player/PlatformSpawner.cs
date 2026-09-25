using UnityEngine;

public class PlatformSpawner : MonoBehaviour {
    [SerializeField] private Platform platformPrefab;
    private int platformsSpawned;
    [SerializeField] private int numPlatforms;

    private AudioManager audioManager;

    private void Awake() {
        audioManager = GetComponent<AudioManager>();
        platformsSpawned = 0;
    }

    private void Update() {
        if((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && platformsSpawned < numPlatforms) {
            Platform platInstance = Instantiate(platformPrefab, transform.position, Quaternion.identity);

            audioManager.PlaySound("Spawn Platform");
            platInstance.Spawn();
            platformsSpawned++;
        }
    }
}
