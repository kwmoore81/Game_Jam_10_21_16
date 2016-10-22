using UnityEngine;
using System.Collections;

public class Game_Over : MonoBehaviour {

    public Transform canvas;

    public void gameOver()
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

