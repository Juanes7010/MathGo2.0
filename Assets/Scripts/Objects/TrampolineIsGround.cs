using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineIsGround : MonoBehaviour
{
    public static bool IsGroundedTrampoline; //Static es para poder usar la  variable en otra clase

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsGroundedTrampoline = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsGroundedTrampoline = false;
        }
    }
}
