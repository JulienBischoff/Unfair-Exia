using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartInDeath : MonoBehaviour
{
    public void RESTART()
    {
        FindObjectOfType<GameManager>().Restart();
    }
}
