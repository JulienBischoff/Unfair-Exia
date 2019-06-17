using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject deathCanvas;
    public GameObject winCanvas;
    public Text textWin;
    public bool isVert;
    public Vector3 PositionInitiale = new Vector3(0.48f, 1.09f);

    private GameObject player;

    public int nbLevel = 1;

    public void Death()
    {
        Score.nbMort++;
        deathCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Win()
    {
        textWin.text = ("Félications !\n \n Vous venez de finir Unfair 1D !!\n Vous avez fini avec "+ Score.nbMort +" morts !");
        winCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        BaseManager.baseManager.Reload(1);
        BaseManager.baseManager.Reload(2);
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.transform.position = PositionInitiale;
        Time.timeScale = 1;
    }

    public void RestartAndReset()
    {
        BaseManager.baseManager.Reload(1);
        BaseManager.baseManager.Reload(2);
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.transform.position = PositionInitiale;
        Time.timeScale = 1;
        Score.nbMort = 0;
    }
    
    public void ChangeModeDifficulte()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<PlatformerCharacter2D>().m_AirControl = !player.GetComponent<PlatformerCharacter2D>().m_AirControl;
    }

}
