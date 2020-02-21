using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDisable : MonoBehaviour
{

    public GameObject noPlay;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Breaks the game by disabling the game object     
        if (Input.GetKeyDown(KeyCode.Q))
        {
            noPlay.SetActive(false);
        }
    }
}