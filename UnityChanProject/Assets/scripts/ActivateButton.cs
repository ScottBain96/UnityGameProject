using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButton : MonoBehaviour {
    public GameObject GameObject;
	// Use this for initialization
	void Start () {
		
	}
    public string hello;
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "KeyBox")
        {
            hello = "yes";
            GameObject.Destroy(GameObject);
        }
        else {

            hello = "no";
        }
    }
}
