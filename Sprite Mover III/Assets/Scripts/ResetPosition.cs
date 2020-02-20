using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private Vector3 original;

    // Use this for initialization
    void Start()
    {
        //original = gameObject.transform.position;
        original = new Vector3(0, 0, -2);
    }

    // Update is called once per frame
    void Update()
    {
        //Hitting space will reset the player's position to the center of the world
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = original;
        }
    }
}
