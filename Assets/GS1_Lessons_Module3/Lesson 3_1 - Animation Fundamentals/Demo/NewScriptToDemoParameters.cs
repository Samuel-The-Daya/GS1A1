using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScriptToDemoParameters : MonoBehaviour
{
    public Animator animator;

    public bool isButtonDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isButtonDown = Input.GetButton("Jump");
        animator.SetBool("Condition", isButtonDown);
    }
}
