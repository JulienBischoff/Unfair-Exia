using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int nbMort;
    public static Text score;

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
        score.text = "Nombre de mort: 0";

    }
	
	// Update is called once per frame
	void Update () {
        score.text = "Nombre de mort: " + nbMort;
	}
}
