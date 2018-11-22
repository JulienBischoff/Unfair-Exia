using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RestartInDeath : MonoBehaviour {

    // Use this for initialization
    public void RESTART()
    {
            FindObjectOfType<GameManager>().Restart();
    }
}
