using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject restartObject;
    public GameObject playerObject;
    public string checkpointName = "checkpoint";
    public string restartName = "restart";
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown(restartName))
        {
            transform.position = restartObject.transform.position;
        }
    }
}
