using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject canvas;
    public bool isVert;

    private GameObject player;

    public int nbLevel = 1;

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
        BaseManager.baseManager.Reload(1);
        BaseManager.baseManager.Reload(2);
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.transform.position = new Vector3(0.48f, 1.09f);
        Time.timeScale = 1;
    }

}
