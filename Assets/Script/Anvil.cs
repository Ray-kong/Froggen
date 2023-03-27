using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil : MonoBehaviour
{

    private bool stopped;
    // Start is called before the first frame update
    void Start()
    {
        stopped = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            transform.gameObject.tag = "Untagged";
        }
    }
}
