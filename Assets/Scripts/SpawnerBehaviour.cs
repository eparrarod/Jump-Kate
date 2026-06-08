using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class SpawnerBehaviour : MonoBehaviour {
    public GameObject platformPrefab;
    public float minLength;
    public float maxLength;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Vector3 pos = transform.position;
        pos.y = pos.y - 2.0f;
        GameObject Newplatf = Instantiate(platformPrefab, pos, Quaternion.identity);
        float randomLength = Random.Range(minLength, maxLength);
        Vector3 newScale = Newplatf.transform.localScale;
        newScale.x = randomLength;
        Newplatf.transform.localScale = newScale;
    }

    // Update is called once per frame
    void Update() {
        
    }
}
