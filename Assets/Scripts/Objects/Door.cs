using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    Animator animator;
    public GameObject gameObject;
    public string NameScene;
    bool Entry = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Entry)
        {
            if (Input.GetKey("w"))
            {
                SceneManager.LoadScene(NameScene);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(true);
            Entry = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Entry = false;
        }
    }
}
