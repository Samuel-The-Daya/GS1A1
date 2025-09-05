
using UnityEngine;

// Press a button (Spacebar) to add an impulse force to an object. 
// You could also do this by combining the ButtonPressToEvent + Physics Booster scripts. 
// Physics Booster has a few extra settings and options as well. 

// This script requires both a 2D Rigidbody and Collider2D (Any type)
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class ButtonPressToForce : MonoBehaviour
{
    // The rigidbody to add the force to. 
    private Rigidbody2D rigid;

    [Header("Options")]
    public Vector2 forceDirectionAndMagnitude = Vector2.one;

    private bool buttonPressed = false;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // Refactor needs to b in fixed update
    void Update()
    {
        // When the button is pressed (on that specific frame), add an impulse force. 
        if (Input.GetButtonDown("Jump"))
        {
            buttonPressed = true;
        }
    }

    // Need to seperate these so the button is listened for in the Update loop,
    // but the physics are fired in Fixed Update. 
    private void FixedUpdate() {
        if (buttonPressed) {
            rigid.AddForce(forceDirectionAndMagnitude, ForceMode2D.Impulse);
            buttonPressed = false;
        }
    }
}
