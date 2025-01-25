using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SnowmanMove : MonoBehaviour
{
    public float rightang = -15f;//Roll to the right
    public float leftang = 15f;//Roll to the left

    public float movespeed = 1f;//Roll speed

    public float t = 0f;//Lerp's value

    public bool gobcak = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gobcak == true)//When the lerp value is 1, it means that the object has moved to the target position immediately after the reverse
        {

            t -= movespeed * Time.deltaTime;//Control the snowman to spin
            if (t <= 0f)//Determine that lerp has reached a predetermined value
            {
                t = 0f;
                gobcak = false;
            }
        }
        else//It's also the opposite of the above
        {
            t += movespeed * Time.deltaTime;//Control the snowman to spin
            if (t >= 1f)//Determine that lerp has reached a predetermined value
            {
                t = 1f;
                gobcak = true;
            }
        }
        float ppp = Mathf.Lerp(rightang, leftang, t);
        transform.localEulerAngles = new Vector3(0, 0, ppp);//Map the lerp value to the three values of the object's rotation around the z axis
    }
    }
