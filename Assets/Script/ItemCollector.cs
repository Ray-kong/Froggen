using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int score = 0;

    [SerializeField] private Text ScoreText;
    [SerializeField] private Text EndText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item")) {
            Destroy(collision.gameObject);
            score++;
            Debug.Log("Score: " + score);
            ScoreText.text = "Score: " + score;
            EndText.text = score + "/24 Flies Collected";
        }
    }


} 
