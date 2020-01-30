using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DisplayMode : MonoBehaviour
{
    public GameObject lighter;

    public GameObject darker;

    private bool darkEnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ModeChange()
    {
        if (darkEnable == false)
        {
            lighter.GetComponent<TilemapRenderer>().sortingOrder = -1;
            darker.GetComponent<TilemapRenderer>().sortingOrder = 0;
            darkEnable = true;
            FileKeep.DarkEnable = true;
        }
        else
        {
            lighter.GetComponent<TilemapRenderer>().sortingOrder = 0;
            darker.GetComponent<TilemapRenderer>().sortingOrder = -1;
            darkEnable = false;
            FileKeep.DarkEnable = true;
        }
    }
}
