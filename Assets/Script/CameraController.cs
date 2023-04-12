using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    //private Camera camera = GetComponent<Camera>();

    // Update is called once per frame
    public Camera OrthographicCamera;


    private void Start()
    {
        OrthographicCamera.enabled = true;

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            OrthographicCamera.orthographicSize = 15;
            transform.position = new Vector3(player.position.x, player.position.y + 1.5f, transform.position.z);
            Debug.Log("this worked");
        }
        else {
            OrthographicCamera.orthographicSize = 6;
            transform.position = new Vector3(player.position.x, player.position.y + 1.5f, transform.position.z);
        }

    }
}
