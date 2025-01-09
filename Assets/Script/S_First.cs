using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_First : MonoBehaviour
{
    float speed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        



        pos.x += speed;

        Vector2 pos1 = Camera.main.WorldToScreenPoint(pos);

        if (pos1.x >= Screen.width) {

            speed = speed * -1;



        }
        else if (pos1.x <= 0)
        {

            speed = speed * -1;



        }

       

        transform.position = pos;
    }
}
