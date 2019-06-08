using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && win.activeSelf)
            SceneManager.LoadScene(0);
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }

    public GameObject win;
    public GameObject music;

    private void OnTriggerEnter(Collider other)
    {
        win.SetActive(true);
        music.SetActive(false);
    }
}
