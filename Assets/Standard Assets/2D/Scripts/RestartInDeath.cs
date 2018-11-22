using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RestartInDeath : MonoBehaviour {

    bool isTrigger = false;

    // Use this for initialization
    public void RESTART()
    {
        if (!isTrigger)
        {
            FindObjectOfType<GameManager>().Restart();
        }
    }
}
