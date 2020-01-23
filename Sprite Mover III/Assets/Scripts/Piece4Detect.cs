using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece4Detect : MonoBehaviour
{
    public bool activated4 = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Touching 4");
        activated4 = true;
    }
}