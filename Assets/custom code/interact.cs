using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public GameObject playerobj;
    public bool interacting = false;
    public Vector2 direction;
    public string interactName = "fire1";
    public float rayCastDistance = 6f;
    public LayerMask affectLayer;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(interactName))
        {
            RaycastHit2D hit = Physics2D.Raycast(this.playerobj.transform.position, direction, rayCastDistance, affectLayer);
            if (hit)
            {
                hit.rigidbody.gravityScale *= -1;

//                interacting = true;
            }
        }
    }
}
