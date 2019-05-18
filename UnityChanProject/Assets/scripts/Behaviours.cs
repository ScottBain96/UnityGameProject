using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviours : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("x"))
        {
            GetComponent<Animator>().Play("SLIDE00", 0, 0f);

        }

       // if (Input.GetKeyDown("1"))
       // {
         //   GetComponent<Animator>().Play("POSE31", 0, 0f);

       // }
        if (Input.GetKeyDown("2"))
        {
            GetComponent<Animator>().Play("WIN00", 0, 0f);

        }
        if (Input.GetKeyDown("1"))
        {
            GetComponent<Animator>().Play("smile2@unitychan", 0, 0f);

        }




    }

    void OnTriggerEnter(Collider col)

    {
        if (col.tag == "jumpSpot")
        {
            GetComponent<Animator>().Play("POTRO", 0, 0f);

        }

    }
}
