using UnityEngine;

public class LevelTransition : MonoBehaviour {
    private BoxCollider2D trigger;
    private AudioManager audioManager;
    [SerializeField] private string nextLevel;

    private void Awake() {
        trigger = GetComponent<BoxCollider2D>();
        audioManager = GetComponent<AudioManager>();
        Cursor.lockState = CursorLockMode.None;
    }

    private void Start() {
        audioManager.PlaySound("Change Level");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag != "Player")
            return;

        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevel);
    }
}
