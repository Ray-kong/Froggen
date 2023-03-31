using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private BoxCollider2D co;
    private Vector2 cp;
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        co = GetComponent<BoxCollider2D>();
        cp = transform.position;
        Debug.Log("initial CP: " + cp);

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
            Debug.Log("oops!");
            Die();
        }
        if (collider.gameObject.CompareTag("trigger"))
        {
            collider.gameObject.GetComponent<TriggeredObject>().TriggerSetOff();
           
        }
        if (collider.gameObject.CompareTag("checkpoint"))
        {
            Debug.Log("check point saved!");
            cp = collider.gameObject.transform.position;
            Debug.Log("new CP: " + cp);

        }
    }

    public void Die()
    {
        anim.SetTrigger("death");
        co.enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void RestartLevel() {
        anim.SetTrigger("spawn");
        transform.position = cp + new Vector2(0, 5);
        Debug.Log("respawn: " + transform.position);
        co.enabled = true;
        rb.bodyType = RigidbodyType2D.Dynamic;
        

    }


}
