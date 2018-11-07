using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartInDeath : MonoBehaviour {

	// Use this for initialization
	public void RESTART()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }
}
