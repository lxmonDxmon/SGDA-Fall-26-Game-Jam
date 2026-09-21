using UnityEngine;

public class LevelTransition : MonoBehaviour {
    private BoxCollider2D trigger;
    [SerializeField] private string nextLevel;

    private void Awake() {
        trigger = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag != "Player")
            return;

        UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevel);
    }
}
