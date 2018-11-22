using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseManager : MonoBehaviour {

    public static BaseManager baseManager;

    bool gameStart;

    private GameObject player;

	// Use this for initialization
	void Awake () {
        if (!gameStart)
        {
            baseManager = this;

            
            //SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive); //ligne a décommenter pour build

            gameStart = true;
        }
		
	}

    public void LoadScene(int scene)
    {
        if (SceneManager.GetSceneByBuildIndex(scene) != null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = new Vector3(0.48f, 1.09f);
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
        }
    }

    public void UnloadScene(int scene)
    {
        StartCoroutine(Unload(scene));
    }

    IEnumerator Unload(int scene)
    {
        yield return null;

        SceneManager.UnloadSceneAsync(scene);
    }

	
}
