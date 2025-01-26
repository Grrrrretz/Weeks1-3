using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_SnowRoateing : MonoBehaviour
{
    public float rotatspeed = -30f;
    public float godownspeed = 1f;
    public AnimationCurve curve;

    [Range(0, 1)]
    public float anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;//Gets the rotation of an object to change the rotation of the object
        Vector3 orgposition = transform.position;//Gets the position of the object to change the position of the object

        rotation.z += rotatspeed *curve.Evaluate(anim) * Time.deltaTime;//Adding a speed value to the Z-axis uses the object to rotate, using deltatime as a limit to smooth the rotation

        transform.eulerAngles = rotation;//Assigns the rotation value back to the original value

        orgposition.y -= godownspeed * Time.deltaTime;//Add the speed value to the Y-axis of position to make the object drop, and use deltatime as a limit to make the movement smoother


        Vector3 nowposition = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, transform.position.z));//Get the world coordinates in the bottom left corner of the screen as the origin coordinates for the subsequent condition decision as a condition
        Vector3 newposition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, transform.position.z));//Get the world coordinates in the top right corner of the screen as the pole coordinates for the subsequent condition decision as a condition


        if (orgposition.y <= nowposition.y)//Determine that the snowflake has reached the bottom of the screen
        {
            orgposition.y = newposition.y;//Reset the snowflake position to the top of the screen
        }
        if (orgposition.x >= newposition.x)//Check that snowflakes have reached the right side of the screen
        {
            orgposition.x = nowposition.x;//Reset the snowflake position to the left of the screen
        }
        else if(orgposition.x <= nowposition.x)//Check for snowflakes to the left of the screen
        {
                orgposition.x = newposition.x;//Reset the snowflake position to the right of the screen
        }
        transform.position = orgposition * curve.Evaluate(anim);//Assign new position values to the original values, and use animation curves to manipulate the animation speed to make it more natural
    }
}
