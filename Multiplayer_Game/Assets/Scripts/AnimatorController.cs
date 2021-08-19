using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    Vector2 input;
    

    void Start()
    {
        animator = GetComponent<Animator>();
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }

    
    void Update()
    {
        animator.SetFloat("Xinput", input.x);
        animator.SetFloat("Yinput", input.y);
    }
}
