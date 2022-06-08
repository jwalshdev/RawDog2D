using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidBody;
    private SpriteRenderer collisionObj;
    [SerializeField] private Scene scene2;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionObj = collision.gameObject.GetComponent<SpriteRenderer>();

        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("Portal"))
        {
            if (collisionObj.enabled) 
            {
                SceneManager.LoadScene("scene2");
            }
        }
    }

    private void Die()
    {
        animator.SetTrigger("Death");
        rigidBody.bodyType = RigidbodyType2D.Static;
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
