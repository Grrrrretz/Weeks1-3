using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ClockHourHand : MonoBehaviour
{
    Boolean time = true;
    public float speed = -10f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.z += speed * Time.deltaTime;

        transform.eulerAngles = rotation;

        //if (Input.GetMouseButtonDown(1));
        //{

        //    time = false;
        
        //}
        //if (Input.GetMouseButtonUp(1)) ;
        //{

        //    time = true;

        //}
        //if(time == true)
        //{



        //}



    }
}
