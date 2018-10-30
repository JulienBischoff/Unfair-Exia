using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlateform : MonoBehaviour {

    public GameObject plateform;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            plateform.GetComponent<BoxCollider2D>().isTrigger = true;
            plateform.GetComponent<Rigidbody2D>().isKinematic = false;
        }

    }
	
}
