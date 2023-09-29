using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsProvider : MonoBehaviour
{
    public event Action<GameObject> OnHit = delegate { };


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            OnHit(hit.transform.gameObject);

        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}

public class Events : MonoBehaviour
{
    public EventsProvider eventsProvider;

    private void Start()
    {
        eventsProvider.OnHit += UseEvent;
    }

    private void UseEvent(GameObject go)
    {
        //DO
    }
}
