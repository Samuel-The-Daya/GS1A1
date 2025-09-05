using UnityEngine;
using UnityEngine.Events;

// Press Spacebar to trigger a Unity Event. 
// Includes options for pressed, released or held. 
// Only Space for now, we can expand it later. 
// This version of the class includes some workarounds if you are calling Physics based scripts (PhysicsBooster)
public class ButtonPressToEventForPhysics : MonoBehaviour
{
    public UnityEvent onButtonPressEvent = new UnityEvent();
    public UnityEvent onButtonHeldEvent = new UnityEvent(); // called each frame the button is held. 
    public UnityEvent onButtonReleasedEvent = new UnityEvent();

    public bool DEBUG_MODE = false;

    private bool buttonDown = false;
    private bool buttonHeld = false;
    private bool buttonReleased = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            buttonDown = true;
            if (DEBUG_MODE) { Debug.Log("Jump Button Pressed"); }
        }

        if (Input.GetButton("Jump"))
        {
            buttonHeld = true;
            if (DEBUG_MODE) { Debug.Log("Jump Button Held"); }
        } else {
            buttonHeld = false; // make sure we shut it off. 
        }

        if (Input.GetButtonUp("Jump"))
        {
            buttonReleased = true;
            if (DEBUG_MODE) { Debug.Log("Jump Button Released"); }
        }

    }

    // Update is called once per frame
    void FixedUpdate() {
        if (buttonDown) {
            onButtonPressEvent.Invoke();
            buttonDown = false;
        }

        if (buttonHeld) {
            onButtonHeldEvent.Invoke();
        }

        if (buttonReleased) {
            onButtonReleasedEvent.Invoke();
            buttonReleased = false;
        }

    }
}
