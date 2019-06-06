using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModeDifficulte : MonoBehaviour
{
    public void CHANGEMODE()
    {
        FindObjectOfType<GameManager>().ChangeModeDifficulte();
    }
}
