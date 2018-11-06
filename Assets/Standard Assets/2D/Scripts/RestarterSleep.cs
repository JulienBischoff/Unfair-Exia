using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class RestarterSleep : MonoBehaviour
    {
        public float sleepTime = 2f;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                StartCoroutine(RestartWithSleep());
            }
        }

        IEnumerator RestartWithSleep()
        {
            yield return new WaitForSeconds(sleepTime);
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }

    }
}
