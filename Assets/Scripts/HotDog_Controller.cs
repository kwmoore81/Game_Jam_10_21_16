using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class HotDog_Controller : MonoBehaviour {

   
    private Win_Condition win_condition;

    void Start()
    {

        win_condition = GameObject.FindWithTag("MainCamera").GetComponent<Win_Condition>();

    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            win_condition.winCondition();
            Destroy(gameObject);
        }
    }
}
