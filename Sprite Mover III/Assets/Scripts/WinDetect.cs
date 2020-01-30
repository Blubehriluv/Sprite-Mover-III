using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;
using UnityEngine.SceneManagement;

public class WinDetect : MonoBehaviour
{
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;
    public Movement move;

    //private Transition myParent = GetComponent<Transition>();

    // Start is called before the first frame update
    void Start()
    {
        trigger1 = GameObject.FindGameObjectWithTag("Trigger1");
        trigger2 = GameObject.FindGameObjectWithTag("Trigger2");
        trigger3 = GameObject.FindGameObjectWithTag("Trigger3");
        trigger4 = GameObject.FindGameObjectWithTag("Trigger4");
        

    }

    // Update is called once per frame
    void Update()
    {
        WinChecker();
    }

    void WinChecker()
    {
        /*if (win.activated1 == true && win2.activated2 == true && win3.activated3 == true && win4.activated4 == true)
        {
            Debug.Log("YOU WON YOU ACTUALLY WON");
        }*/

        if (trigger1.GetComponent<PieceDetect>().activated1 == true && trigger2.GetComponent<Piece2Detect>().activated2 == true && trigger3.GetComponent<Piece3Detect>().activated3 == true && trigger4.GetComponent<Piece4Detect>().activated4 == true)
        {
            StartCoroutine(waiter());
            Debug.Log("YOU WON YOU ACTUALLY WON");
            waiter();
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        move.speed = 0;
        yield return new WaitForSeconds(5);
        LoadLevel("LevelSelect");
    }

    void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
