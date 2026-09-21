using UnityEngine;

public class Platform : MonoBehaviour {
    private SpriteRenderer sprite;

    private void Awake() {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void Spawn() {
        transform.position = new Vector3(transform.position.x, transform.position.y - sprite.size.y, transform.position.z);
    }
}
