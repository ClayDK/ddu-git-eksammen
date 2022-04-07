using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antigrav : MonoBehaviour
{
    public interact interacting;
    
    public void ActivateGravity(bool activate) 
    {
        GetComponent<Rigidbody2D>().gravityScale *= -1;
    }
}
