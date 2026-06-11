using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class SpawnerBehaviour : MonoBehaviour {
    public GameObject platformPrefab;
    public float min = 0.88f; // 0.70-2
    public float max = 6.0f; // 7.5-10.32
    public float minPos = -8.61f; // 0.70-2
    public float maxPos = 8.61f; // 7.5-10.32
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        createPlatform();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void createPlatform() {
        Vector3 spawnerPos = transform.position;
        spawnerPos.y = spawnerPos.y - 2.0f;
        GameObject newPlatform = Instantiate(platformPrefab, spawnerPos, Quaternion.identity);
        float randomLength = Random.Range(min, max);
        // assign the randomLength to the newly created object
        Vector3 scale = newPlatform.transform.localScale;
        scale.x = randomLength;
        newPlatform.transform.localScale = scale;
        // place it at a random position 
        float randomPosition = Random.Range(minPos, maxPos);
        Vector3 newPosition = newPlatform.transform.position;
        newPosition.x = randomPosition;
        newPlatform.transform.position = newPosition;
    }
}
