using UnityEngine;
using System.Collections;

public class Volcano_Control : MonoBehaviour {

   // Collider2D volcano;
    public Rigidbody2D rexRB;
    public float upThrust = 400;
    public bool thrustControl = false;
    float thrust = 0;
	// Use this for initialization
	void Start () {
        //volcano = GetComponent<Collider2D>();
        rexRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (thrustControl == true)
        {
            upThrust += upThrust * Time.deltaTime;
        }

        else if (thrustControl == false)
        {
            upThrust -= upThrust * Time.deltaTime;
        }

        if (upThrust <= 400)
        {
            thrustControl = true;          
        }

        else if (upThrust >= 700)
        {
            thrustControl = false;
        }
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        rexRB.AddForce(Vector3.up * upThrust);
        rexRB.AddForce(Vector3.right * 50);
        //thrust = 100000;
        Debug.Log("Collider Triggered!");
    }   

}
