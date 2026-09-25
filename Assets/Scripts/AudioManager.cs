using UnityEngine;

public class AudioManager : MonoBehaviour {
    private AudioSource audioSource;

    [Header("Sound Effects")]
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip platformSpawnSound;
    [SerializeField] private AudioClip levelChangeSound;
    [SerializeField] private AudioClip endSound;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(string sound) {
        switch(sound) {
            case "Jump": audioSource.clip = jumpSound; break;
            case "Spawn Platform": audioSource.clip = platformSpawnSound; break;
            case "Change Level": audioSource.clip = levelChangeSound; break;
            case "End Game": audioSource.clip = endSound; break;
            default: break;
        }

        audioSource.Play();
    }
}
