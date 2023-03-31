using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public float endX;
    public float endY;
    public float velocityX;
    public float velocityY;

    // type is one of the following:
    // Track: object on a track, moves back and forth (such as buzzsaw)
    // Falling: object that falls once and stays in the scene. This is always triggered (such as anvil)
    // Loop: object that falls, disappears, and falls again along the same path (such as wrench)
    public string type;
    // States whether the object needs a trigger to move. If true, then it must have a collider with a trigger as a child
    public bool needsTrigger;

    private float posX;
    private float posY;
    private float startX;
    private float startY;
    private bool isTriggered;

    void Start()
    {
        posX = GetComponent<Rigidbody2D>().position.x;
        posY = GetComponent<Rigidbody2D>().position.y;
        startX = GetComponent<Rigidbody2D>().position.x;
        startY = GetComponent<Rigidbody2D>().position.y;
        isTriggered = !needsTrigger;

    }


    // Update is called once per frame
    void Update()
    {
        if (needsTrigger)
        {
            isTriggered = GetComponentInChildren<TriggeredObject>().isTriggerSetOff();
        }

        if (isTriggered)
        {
            if (type.Equals("Track"))
            {
                if ((endX > 0 && ((posX < startX && velocityX < 0) || (posX > endX + startX && velocityX > 0)))
                   || (endX < 0 && ((posX > startX && velocityX > 0) || (posX < endX + startX && velocityX < 0))))
                {
                    velocityX = -1 * velocityX;
                }
                if ((endY > 0 && ((posY < startY && velocityY < 0) || (posY > endY + startY && velocityY > 0)))
                   || (endY < 0 && ((posY > startY && velocityY > 0) || (posY < endY + startY && velocityY < 0))))
                {
                    velocityY = -1 * velocityY;
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);
                posX = GetComponent<Rigidbody2D>().position.x;
                posY = GetComponent<Rigidbody2D>().position.y;
            }

            if (type.Equals("Falling"))
            {
                //   if (GetComponentInChildren<TriggeredObject>().isTriggerSetOff())
                // {
                GetComponent<Rigidbody2D>().gravityScale = 2;
                // }
            }

            if (type.Equals("Loop"))
            {
                if ((endX > 0 && posX > endX + startX) || (endX < 0 && posX < endX + startX)
                   || (endY > 0 && posY > endY + startY) || (endY < 0 && posY < endY + startY))
                {
                    GetComponent<Transform>().position = new Vector3(startX, startY, 0);
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);
                posX = GetComponent<Rigidbody2D>().position.x;
                posY = GetComponent<Rigidbody2D>().position.y;
            }
        }


    }
}
