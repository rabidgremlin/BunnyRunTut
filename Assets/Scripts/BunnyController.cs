using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {

    private Rigidbody2D myRigidBody;
    private Animator myAnim;
    public float bunnyJumpForce = 500f;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
	 if (Input.GetButtonUp("Jump"))
        {
            myRigidBody.AddForce(transform.up * bunnyJumpForce);
        }

        myAnim.SetFloat("vVelocity",  myRigidBody.velocity.y);
    }
}
