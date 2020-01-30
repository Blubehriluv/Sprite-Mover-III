using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceDetect : MonoBehaviour
{
    public bool activated1;
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
        Debug.Log("Touching 1");
        activated1 = true;
    }
}
