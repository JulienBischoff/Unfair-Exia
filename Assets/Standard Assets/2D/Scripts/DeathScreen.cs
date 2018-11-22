using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    bool isTrigger = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (!isTrigger)
            {
                isTrigger = true;
                FindObjectOfType<GameManager>().Death();
            }
        }

    }

}