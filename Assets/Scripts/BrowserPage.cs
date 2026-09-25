using UnityEngine;

public class BrowserPage : MonoBehaviour {
    private BoxCollider2D trigger;

    private void Awake() {
        trigger = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag != "Player")
            return;

        // play click sound from player because browser can't play sound once it's destroyed
        Player player = collision.gameObject.GetComponent<Player>();
        player.audioManager.PlaySound("Change Level");

        Destroy(gameObject);
    }
}
