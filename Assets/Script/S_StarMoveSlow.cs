using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_StarMoveSlow : MonoBehaviour
{
    public float speedslow = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;//Use eulerangles to control rotation

        rotation.z += speedslow * Time.deltaTime;//Add the speed value to change the value of the z-axis to achieve the rotation effect

        transform.eulerAngles = rotation;//Update the rotation value by assigning a new value to the original rotation value
    }
}
