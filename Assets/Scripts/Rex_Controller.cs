using UnityEngine;
using System.Collections;

public class Rex_Controller : MonoBehaviour {

    static Animator rexAnimator;
    public Rigidbody2D rexRB;

    // Use this for initialization
    void Start () {
        rexAnimator = GetComponent<Animator>();
        rexRB = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {
            rexAnimator.SetTrigger("isJumping");
            rexRB.AddForce(Vector3.right * 120);
        }
	
	}
}
