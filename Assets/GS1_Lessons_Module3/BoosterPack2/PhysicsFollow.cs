using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsFollow : MonoBehaviour
{
    // To Follow
    public Transform followTarget;
    public Rigidbody2D rb;

    public float moveForce = 5f;

    public float maxVelocity = 10f;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        // Follow an object, stop adding force if the velocity exceeds the maxVelocity value
        if(rb.velocity.magnitude < maxVelocity) {
            Vector2 toTarget = followTarget.position - transform.position;
            Vector2 directionNormalized = toTarget.normalized;
            float directionMagnitude = toTarget.magnitude;

            rb.AddForce( directionNormalized * moveForce );
        }

    }
}
