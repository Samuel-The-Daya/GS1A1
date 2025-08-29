// Don't touch
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Should look like this
// Name NEEDS to match your file eg. BasicMovement.cs
public class BasicMovement : MonoBehaviour
{
    public float xInput;

    public float forceAmount = 1f;
    public Vector2 forceApplied;

    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        forceApplied = new Vector2 (xInput, 0) * forceAmount;

        
        rigid.AddForce(forceApplied );
    }
}
