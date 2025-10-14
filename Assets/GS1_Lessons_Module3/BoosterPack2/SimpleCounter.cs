using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleCounter : MonoBehaviour
{
    [Header("Unity Events")]
    public UnityEvent On_NumberAdded = new UnityEvent();
    public UnityEvent On_ReachedCompletion = new UnityEvent();
    public UnityEvent On_ReachedNegativeNumber = new UnityEvent();
    public UnityEvent On_Reset = new UnityEvent();
    public UnityEvent On_SetNewMax = new UnityEvent();

    [Header("Settings")]
    public int count = 0;
    public int maxCount = 10;
    public bool resetOnCompletion = true;
    
    // Add one value to the counter
    public void AddToCounter() {
        count++;
        On_NumberAdded.Invoke();

        CheckConditions();
    }

    // Add an amount to the counter
    public void AddToCounter(int amount) {
        count += amount;
        CheckConditions();
    }

    // check our ending conditions
    private void CheckConditions() {
        
        if(count>= maxCount) {
            On_ReachedCompletion.Invoke();

            if (resetOnCompletion) {
                Reset();
            }
        }
    }

    // Reset the timer
    public void Reset() {
        count = 0;
        On_Reset.Invoke();
    }

    // Set a new max value
    public void SetNewMax(int maxAmount) {
        maxCount = maxAmount;
        On_SetNewMax.Invoke();
    }

}
