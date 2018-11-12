using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFeu : MonoBehaviour {



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (!FindObjectOfType<GameManager>().isVert)
            {
                FindObjectOfType<GameManager>().Death();
            }
        }
    }
}
