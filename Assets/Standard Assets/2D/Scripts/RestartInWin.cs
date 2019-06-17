using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartInWin : MonoBehaviour
{
    public void RESTART()
    {
        FindObjectOfType<GameManager>().RestartAndReset();
    }
}
