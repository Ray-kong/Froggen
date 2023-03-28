using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredObject : MonoBehaviour
{

    public Collider2D trigger;
    private bool triggerSetOff;

    // Start is called before the first frame update
    void Start()
    {
        triggerSetOff = false;
    }

    public void TriggerSetOff()
    {
        triggerSetOff = true;
    }

    public bool isTriggerSetOff()
    {
        return triggerSetOff;
    }
}
