using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFeu : MonoBehaviour {

    public GameObject feu;
    public Sprite feuRouge;
    public Sprite feuVert;

    private float count = 0f;

    private void Start()
    {
        FindObjectOfType<GameManager>().isVert = true;
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count>0 && count<10)
        {
            FindObjectOfType<GameManager>().isVert = true;
            feu.GetComponent<SpriteRenderer>().sprite = feuVert;
        }
        else if (count>=10 && count<20)
        {
            FindObjectOfType<GameManager>().isVert = false;
            feu.GetComponent<SpriteRenderer>().sprite = feuRouge;
        }
        else
        {
            count = 0f;
        }
        
    }
}
