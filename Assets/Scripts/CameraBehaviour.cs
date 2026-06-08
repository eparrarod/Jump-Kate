using System;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
    private Camera cam;
    public float offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("jumper")) {
            Vector3 newPos = cam.transform.position;
            newPos.y = newPos.y + offset;
            cam.transform.position = newPos;
        }
        else {
            print(other.gameObject.name);
        }
    }
}
