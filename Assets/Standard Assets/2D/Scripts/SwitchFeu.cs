using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFeu : MonoBehaviour {

    public GameObject feu;
    public Sprite feuRouge;
    public Sprite feuVert;

    bool vert;



    // Update is called once per frame
    void Update()
    {
        vert = FindObjectOfType<GameManager>().isVert;
        if (vert)
        {
            feu.GetComponent<SpriteRenderer>().sprite = feuVert;
        }
        else if (!vert)
        {
            feu.GetComponent<SpriteRenderer>().sprite = feuRouge;
        }
        
    }
}
