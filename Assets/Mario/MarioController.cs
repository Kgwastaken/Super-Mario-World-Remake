using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour
{   
    public float speed = 20f;
    private float moveDirection;
    private Rigidbody rb;
    private bool facingRight = true;


    private void Awake () {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
        moveDirection = Input.GetAxis("Horizontal");
        if (moveDirection > 0 && !facingRight) {
            flipCharacter();
        }
        else if (moveDirection < 0 && facingRight) {
            flipCharacter();
        }
        rb.velocity = new Vector2(moveDirection * speed, rb.velocity.y);
    }

    private void flipCharacter() {
        facingRight = !facingRight;
        transform.Rotate(0f, 100f, 0f);
    }
}
