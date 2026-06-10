using System;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
    public float offset;
    public GameObject spawner;
    public GameObject despawner;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            moveUp(gameObject);
            moveUp(spawner);
            moveUp(despawner);
        }
    }
    
    public void moveUp(GameObject objectToMove){
        Vector3 newPos = objectToMove.transform.position;
        newPos.y = newPos.y + offset;
        objectToMove.transform.position = newPos;
    }
}
