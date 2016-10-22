using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Volcano_Control : MonoBehaviour {

   // Collider2D volcano;
    public Rigidbody2D rexRB;
    public float upThrust = 400;
    public float upThrustMax = 700;
    public float upThrustMin = 400;
    public float rightThrust = 20;
    public bool thrustControl = false;
    public  Slider slider;
  
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

        if (upThrust <= upThrustMin)
        {
            thrustControl = true;          
        }

        else if (upThrust >= upThrustMax)
        {
            thrustControl = false;
        }

        slider.value = upThrust;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        rexRB.AddForce(Vector3.up * upThrust);
        rexRB.AddForce(Vector3.right * rightThrust);
        //thrust = 100000;
        Debug.Log("Collider Triggered!");
    }   

}
