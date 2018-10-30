using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{

    public class Trap : MonoBehaviour
    {
        public Transform piege;
        public Vector2 coordonnees;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Instantiate(piege,(coordonnees), Quaternion.identity);
            }
        }
    }
}
