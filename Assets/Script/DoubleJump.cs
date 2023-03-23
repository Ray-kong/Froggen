using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lilypad"))
        {
            collision.gameObject.SetActive(false);
            GetComponent<PlayerMovement>().CanDoubleJump();
            yield return new WaitForSeconds(3f);
            collision.gameObject.SetActive(true);
        }
    }
}
