using UnityEngine;

public class BrowserPage : MonoBehaviour {
    private BoxCollider2D trigger;

    private void Awake() {
        trigger = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag != "Player")
            return;

        Destroy(gameObject);
    }
}
