using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_spawner : MonoBehaviour
{
    public GameObject PopButton;
    public Sprite[] Button;
    public SpriteRenderer pop1;

    public Vector3 A1 = new Vector3(Random.Range(-10, 10), Random.Range(-5, 5), Random.Range(-5, 5));
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseposition = Camera.main.WorldToScreenPoint(Input.mousePosition);
        if(Button.Length ==0)
        {
         
        }
        else
        {
            if (Button.Length <= 5)
            {
            }
        }
    }
}
