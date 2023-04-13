using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainMover : MonoBehaviour
{
    [SerializeField] private Transform player;


    private void Update()
    {
            transform.position = new Vector3(player.position.x, 5.5f, transform.position.z);
            Debug.Log("this worked");

    }
}
