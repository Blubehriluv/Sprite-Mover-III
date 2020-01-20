using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetect : MonoBehaviour
{
    public GameObject trigger1;

    public GameObject trigger2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Trigger1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
