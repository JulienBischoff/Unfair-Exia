using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject canvas;
    public bool isVert;

    private int time;


    public void Start()
    {
        time = 0;
    }


    public void Update()
    {
        time++;
        if(time>0 && time<500){
            isVert = true;
        }
        else if(time>=500 && time<1000)
        {
            isVert = false;
        }
        else
        {
            time = 0;
        }
    }

    public void Death()
    {
        canvas.SetActive(true);
        Time.timeScale = 0;
    }

}
