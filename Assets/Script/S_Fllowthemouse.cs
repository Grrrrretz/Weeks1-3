using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class S_Fllowthemouse : MonoBehaviour
{
    float move;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Input.mousePosition;

        pos = Camera.main.ScreenToWorldPoint(pos);

        transform.position = new Vector2(pos.x, pos.y);
    }
}
