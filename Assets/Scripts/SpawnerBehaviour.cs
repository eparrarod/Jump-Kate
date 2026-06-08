using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour {
    public GameObject platformPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Vector3 pos = transform.position;
        pos.y = pos.y - 2.0f;
        GameObject Newplatf = Instantiate(platformPrefab, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
