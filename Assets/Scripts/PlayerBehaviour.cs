using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour {
    public float moveSpeed;
    public float jumpForce;
    public bool moving;
    public bool jumping;
   Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        moving = false;
        jumping = false;
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        float currentSpeed = moveSpeed;

        if (Keyboard.current.rightArrowKey.isPressed ||
            Keyboard.current.dKey.isPressed ||
            Keyboard.current.leftArrowKey.isPressed ||
            Keyboard.current.aKey.isPressed) {
            moving = true;
            if (Keyboard.current.rightArrowKey.isPressed ||
                Keyboard.current.dKey.isPressed) {
                currentSpeed = -moveSpeed;
            }
        }
        else {
            moving = false;
        }

        if (moving == true) {
            Vector3 newPos = transform.position;
            newPos.x = newPos.x - currentSpeed;
            transform.position = newPos;
        }
        if (Keyboard.current.upArrowKey.wasPressedThisFrame && jumping == false) {
            jumping = true;
            body.AddForceY(jumpForce, ForceMode2D.Impulse);
        }

    }
    public void OnCollisionEnter2D(Collision2D other) {
        jumping = false;
    }
}
