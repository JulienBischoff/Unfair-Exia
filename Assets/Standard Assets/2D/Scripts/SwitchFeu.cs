using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFeu : MonoBehaviour {

    public GameObject feu;
    public Sprite feuRouge;
    public Sprite feuVert;
    bool isVert;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            if (isVert)
            {
                feu.GetComponent<SpriteRenderer>().sprite = feuRouge;
                isVert = !isVert;
            }
            else
            {
                feu.GetComponent<SpriteRenderer>().sprite = feuVert;
                isVert = !isVert;
            }
        }
    }
}
