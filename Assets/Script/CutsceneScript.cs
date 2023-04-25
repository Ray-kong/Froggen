using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneScript : MonoBehaviour
{

    public GameObject player;
    public GameObject music;
    public GameObject score;
    public GameObject escText;

    private UnityEngine.Video.VideoPlayer vp;
   // private AudioSource audioS;
    private bool videoStarted;

    void Start()
    {
        vp = this.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoStarted = false;
        vp.url = Application.streamingAssetsPath + "/" + "intro_scene.mp4";
        vp.Prepare();
        vp.Play();
      //  as = music.gameObject.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("s"))
        {
            vp.Pause();
        }
        if (vp.isPlaying)
        {
            videoStarted = true;
        }
        if (!vp.isPlaying && videoStarted)
        {
            player.gameObject.SetActive(true);
            music.gameObject.SetActive(true);
            score.transform.GetChild(0).gameObject.SetActive(true);
            escText.gameObject.SetActive(false);
            gameObject.SetActive(false);
            music.GetComponent<AudioSource>().Play();
        }
    }
}
