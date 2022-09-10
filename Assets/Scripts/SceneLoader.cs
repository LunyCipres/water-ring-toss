using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string loadscene = "\0";
    public string unloadscene = "\0";

    public void LoadScene() {
        if (loadscene != "\0") {
            SceneManager.LoadSceneAsync(loadscene, LoadSceneMode.Additive);
            Debug.Log("Scene loaded");
        }
        if (unloadscene != "\0") {
            SceneManager.UnloadSceneAsync(unloadscene);
            Debug.Log("Scene unloaded");
        }
    }
}
