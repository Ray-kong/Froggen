using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCutscene : MonoBehaviour
{

    public GameObject player;
    public GameObject score;
    public GameObject endingCanvas;
    public UnityEngine.Video.VideoPlayer vp;

    private bool videoStarted;

    void Start()
    {
        videoStarted = false;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            player.gameObject.SetActive(false);
            score.gameObject.SetActive(false);
            endingCanvas.gameObject.SetActive(true);
            vp.Play();
            videoStarted = true;
        }

    }

    void Update()
    {
        if (videoStarted && !vp.isPlaying)
        {
            vp.gameObject.SetActive(false);
            endingCanvas.transform.GetChild(1).gameObject.SetActive(true);
            endingCanvas.transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
