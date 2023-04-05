using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.G)) {
            transform.position = new Vector3(player.position.x, player.position.y - 3.5f, transform.position.z);
            Debug.Log("this worked");
        }
        else
        transform.position = new Vector3(player.position.x, player.position.y + 1.5f, transform.position.z);
    }
}
