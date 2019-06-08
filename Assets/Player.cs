using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(PlayerPrefs.GetFloat("x", 0), PlayerPrefs.GetFloat("y", 0), 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed,
            Input.GetAxis("Vertical") * Time.deltaTime * speed, 0);
	}

    public GameObject win;

    private void OnApplicationQuit()
    {
        if (win.activeSelf) return;
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("y", transform.position.y);
    }
}
