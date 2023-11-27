using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
    }
}
