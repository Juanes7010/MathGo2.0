using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    new Transform transform;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            animator.SetBool("Hit", true);
            transform.position = new Vector3(-0.97f, -0.39f);
            
        }
        else
        {
            animator.SetBool("Hit", false);
        }
    }
}
