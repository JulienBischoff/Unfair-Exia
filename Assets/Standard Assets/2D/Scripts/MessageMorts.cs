using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageMorts : MonoBehaviour
{

    public static Text message;
    private static string[] messagesMorts = new string[] {
        "T'es mort comme Chess'Xia",
        "Aussi éclaté que le mur de la 107",
        "Raté, va au rattrapaze",
        "PBL, ca marche pas hein ?",
        "T'as besoin d'un intervenant ?",
        "Définition Nul: Toi",
        "Retournez à la case départ, payez 7000€",
        "T'as pensé au DUT ?",
        "Si tu galères là, j'imagine pas pour le projet JAVA...",
        "Plus dur que de recopier un prosit ?",
        "Intech, c'est mieux",
        "Moins utile qu'un gestionnaire",
        "T'as pas ... Cesi le principe ?",
        "Tes échecs sont comme les multiprises: en série",
        "Plus long qu'organiser la chasse aux oeufs ?",
        "Faut sauter, si jamais...",
        "Je te rappelle que le but c'est de pas mourir hein",
        "Cherche le mot-clé \"noob\"",

        };

    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<Text>();
        message.text = messagesMorts[Random.Range(0, messagesMorts.Length)];
        print("mff");
    }

}
