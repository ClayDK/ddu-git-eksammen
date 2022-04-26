using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TarodevController
{
    public class interact : MonoBehaviour
    {
        public GameObject playerobj;
        public bool interacting = false;
        public Vector2 direction = Vector2.right;
        public string interactName = "Fire1";
        public float rayCastDistance = 6f;
        public LayerMask affectLayer;
        private IPlayerController _player;
        public bool facingRight = true;
        // Start is called before the first frame update
        void Awake()
        {
            _player = GetComponentInParent<IPlayerController>();
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(gameObject.name + ": " + transform.localScale.x);
            Debug.DrawRay(transform.position, direction * transform.localScale.x, Color.blue);
            if (Input.GetButtonDown(interactName))
            {
                Debug.Log(gameObject.name + " Interacting");
                RaycastHit2D hit = Physics2D.Raycast(transform.position, direction * transform.localScale.x, rayCastDistance, affectLayer);

                if (hit)
                {
                    Debug.Log(hit.collider.name + " was hit");
                    hit.rigidbody.gravityScale *= -1;
                    //              interacting = true;
                }
                //if (_player.Input.X > 0 && !facingRight)
                //{

                //}
            }
        }
    }
}
