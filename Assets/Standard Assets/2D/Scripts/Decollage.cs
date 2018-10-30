using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decollage : MonoBehaviour
{

    private Rigidbody2D player_rigidbody2D;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            player_rigidbody2D = other.GetComponent<Rigidbody2D>();
            player_rigidbody2D.AddForce(new Vector2(0f, 2000f));

        }
    }
}
