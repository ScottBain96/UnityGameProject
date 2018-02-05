using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scapeMenu : MonoBehaviour {


    public GameObject canvas;
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("f"))
        {
            canvas.SetActive(true);
            player.SetActive(false);
        }
	}
}
