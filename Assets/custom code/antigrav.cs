using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antigrav : MonoBehaviour
{
    public bool interact = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interact==true) 
        {
            //GetComponent.rigidbody2D;
            //GetComponent<Rigidbody2D>().gravityScale *= -1;
        }
        
    }
}
