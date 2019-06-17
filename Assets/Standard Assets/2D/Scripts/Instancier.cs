using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{

    public class Instancier : MonoBehaviour
    {
        public Transform piege;
        public Vector2 coordonnees;
        private bool isTrigger = false;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                if (!isTrigger)
                {
                    SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1));
                    Instantiate(piege, (coordonnees), piege.rotation );
                    isTrigger = true;
                }
            }
        }
    }
}
