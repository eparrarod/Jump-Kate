using UnityEngine;

public class DespawnerBehaviour : MonoBehaviour {
    public GameObject GameOverPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
    public void OnTriggerEnter2D(Collider2D other) {
        print(other.gameObject.tag);
        if (other.gameObject.CompareTag("Platform")) {
            print(other.gameObject.name);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Player")) {
            GameOverPanel.SetActive(true);
        }
    }
}
