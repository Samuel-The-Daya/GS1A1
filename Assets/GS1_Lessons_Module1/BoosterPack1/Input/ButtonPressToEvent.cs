using UnityEngine;
using UnityEngine.Events;

// Press Spacebar to trigger a Unity Event. 
// Includes options for pressed, released or held. 
// Only Space for now, we can expand it later. 
public class ButtonPressToEvent : MonoBehaviour
{
    public UnityEvent onButtonPressEvent = new UnityEvent();
    public UnityEvent onButtonHeldEvent = new UnityEvent(); // called each frame the button is held. 
    public UnityEvent onButtonReleasedEvent = new UnityEvent();

    public bool DEBUG_MODE = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            onButtonPressEvent.Invoke();
            if (DEBUG_MODE) { Debug.Log("Jump Button Pressed"); }
        }

        if (Input.GetButton("Jump"))
        {
            onButtonHeldEvent.Invoke();
            if (DEBUG_MODE) { Debug.Log("Jump Button Held"); }
        }

        if (Input.GetButtonUp("Jump"))
        {
            onButtonReleasedEvent.Invoke();
            if (DEBUG_MODE) { Debug.Log("Jump Button Released"); }
        }

    }
}
