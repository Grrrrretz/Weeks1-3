using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_First : MonoBehaviour
{
    float speed = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;

        if (pos.x >= 9.5) {

            speed = speed * -1;



        }
        else if (pos.x <= -9.5)
        {

            speed = speed * -1;



        }

        pos.x += speed;

        transform.position = pos;
    }
}
