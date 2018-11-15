using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject canvas;
    public bool isVert;


    public void Update()
    {
    }

    public void Death()
    {
        canvas.SetActive(true);
        Time.timeScale = 0;
    }

}
