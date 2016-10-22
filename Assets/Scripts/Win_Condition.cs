using UnityEngine;
using System.Collections;

public class Win_Condition : MonoBehaviour {

    public Transform canvas;

    public void winCondition()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        //else
        //{
        //    canvas.gameObject.SetActive(false);
        //}
    }
}