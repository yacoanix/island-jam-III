using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSong : MonoBehaviour {

	private static bool created = false;

    void Start()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "race")
        {
            Destroy(gameObject);
			created = false;
        }
    }

}
