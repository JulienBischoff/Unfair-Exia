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

    public void LoadScene(int sceneID)
    {
        if (SceneManager.GetSceneByBuildIndex(sceneID) != null)
        {
            SceneManager.LoadSceneAsync(sceneID, LoadSceneMode.Additive);
        }
    }

    public void UnloadScene(int sceneID)
    {
        StartCoroutine(Unload(sceneID));
    }

    IEnumerator Unload(int sceneID)
    {
        yield return null;

        SceneManager.UnloadSceneAsync(sceneID);
    }

    public void Reload(int sceneID)
    {
        UnloadScene(sceneID);
        LoadScene(sceneID);
    }

	
}
