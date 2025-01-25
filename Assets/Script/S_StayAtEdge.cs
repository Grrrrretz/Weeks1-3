using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_StayAtEdge : MonoBehaviour
{
    //get all withe edge's transform to chage
    public Transform top;
    public Transform bottom;
    public Transform left;
    public Transform right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bottomL = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));//Get the world coordinates in the bottom left corner of the screen
        Vector3 bottomR = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));//Get the world coordinates in the bottom right corner of the screen
        Vector3 topL = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));//Get the world coordinates in the top left corner of the screen
        Vector3 topR = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));//Get the world coordinates in the left right corner of the screen

        //change each withe real time position let it fit in screen
        top.position = new Vector3(0, topL.y, 0);
        bottom.position = new Vector3(0, bottomL.y, 0);
        left.position = new Vector3(bottomL.x, 0, 0);
        right.position = new Vector3(bottomR.x, 0, 0);
    }
}
