using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int score = 0;

    [SerializeField] private Text ScoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item")) {
            Destroy(collision.gameObject);
            score++;
            Debug.Log("score: " + score);
            ScoreText.text = "score: " + score;
        }
    }


} 
