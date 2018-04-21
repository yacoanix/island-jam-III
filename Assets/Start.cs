using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

    public void LoadByIndex(string sceneIndex)
    {
        SceneManager.LoadScene (sceneIndex);
    }
}