using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    Animator animator;
    public Rigidbody2D rb2D;
    public float jumpSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (TrampolineIsGround.IsGroundedTrampoline)
        {
            animator.SetBool("Contact", true);
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
        else
        {
            animator.SetBool("Contact", false);
        }
        
    }
}
