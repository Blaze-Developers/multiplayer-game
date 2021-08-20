using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator anim;
    Vector3 move;
     

    private void Awake()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        anim.SetFloat("Xinput", move.x);
        anim.SetFloat("Yinput", move.y);
    }


}
