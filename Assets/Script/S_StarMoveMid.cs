using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_StarMoveMid : MonoBehaviour
{
    public float speedmid = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.z += speedmid * Time.deltaTime;

        transform.eulerAngles = rotation;
    }
}
