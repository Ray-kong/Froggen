using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private BoxCollider2D co;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        co = GetComponent<BoxCollider2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("death"))
        {
            Die();
        }
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("death"))
        {
              Die();
        }
        if (collider.gameObject.CompareTag("trigger"))
        {
            collider.gameObject.GetComponent<TriggeredObject>().TriggerSetOff();
           
        }
    }

    public void Die()
    {
        anim.SetTrigger("death");
        co.enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }


}
