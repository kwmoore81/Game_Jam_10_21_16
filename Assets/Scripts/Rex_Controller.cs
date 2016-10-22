using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Rex_Controller : MonoBehaviour {

    static Animator rexAnimator;
    public Rigidbody2D rexRB;
    public float thrust = 100;
    public int lives = 3;
    public GameObject rex;
    private bool hasJumped = false;
    private Game_Over gameover;
   
    //private Transform startPosition = position;
    // Use this for initialization
    void Start () {

        rexAnimator = GetComponent<Animator>();
        rexRB = GetComponent<Rigidbody2D>();
        gameover = GameObject.FindWithTag("MainCamera").GetComponent<Game_Over>();
       
    }
	
	// Update is called once per frame
	void Update () {
      
        loseLife();

        if (Input.GetButtonDown("Jump"))
        {
            rexAnimator.SetTrigger("isJumping");
            rexRB.AddForce(Vector3.right * thrust);
            hasJumped = true;
        }
      
        if (lives <= 0)
        {
            gameover.gameOver();
        }
    }
    void loseLife()
    {
           
        if (rexRB.velocity.magnitude == 0.0f && hasJumped == true || transform.position.y < -20.0f && hasJumped == true || transform.position.x > 15.0f && hasJumped == true)
        {
            
            hasJumped = false;

            if (lives > 0)
            {
                --lives;
                Instantiate(rex, new Vector3(-8.67f, 2.36f, 0.0f), Quaternion.identity);
            }

            Destroy(gameObject);

        }

    }

}
