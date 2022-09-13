using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    public float rightLeft = 95;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rightLeft)
        {
            transform.position = new Vector3(rightLeft, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -rightLeft) { 
        transform.position=new Vector3(-rightLeft, transform.position.y, transform.position.z);
        }
    }
}
