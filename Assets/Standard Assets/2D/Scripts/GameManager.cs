using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject canvas;
    public bool isVert;

    private GameObject player;

    public void Update()
    {

    }

    public void Death()
    {
        Score.nbMort++;
        canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        BaseManager.baseManager.UnloadScene(1);
        BaseManager.baseManager.LoadScene(1);
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        Time.timeScale = 1;
    }

}
