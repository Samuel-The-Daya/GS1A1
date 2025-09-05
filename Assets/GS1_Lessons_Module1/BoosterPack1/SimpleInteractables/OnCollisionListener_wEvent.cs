using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionListener_wEvent : MonoBehaviour
{
    public UnityEvent OnCollisionEnter_Event = new UnityEvent();
    public UnityEvent OnCollisionExit_Event = new UnityEvent();

    // When an object interacts with the Collision, call the associated Event. 
    private void OnCollisionEnter2D(Collision2D collision) {
        OnCollisionEnter_Event.Invoke(); // Call the event
    }

    private void OnCollisionExit2D(Collision2D collision) {
        OnCollisionExit_Event.Invoke();
    }
}
