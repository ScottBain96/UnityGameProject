using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeBody : MonoBehaviour {

    public bool isRewinding = false;
    List<Vector3> positions;
    
	// Use this for initialization
	void Start () {
        positions = new List<Vector3>();
        GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown("f"))
            StartRewind();

        if (Input.GetKeyUp("f"))
                StopRewind();
            
        
	}

    private void FixedUpdate()
    {
        if (isRewinding)
            Rewind();
   
        else 
            Record();
        
    }

    void Record() {

        positions.Insert(0, transform.position);

    }


    void Rewind()
    {
        if (positions.Count > 0) {
            transform.position = positions[0];
            positions.RemoveAt(0);

        }
        else
        {
            StopRewind();
        }

    }

    public void StartRewind()
    {
        Time.timeScale = 0.6f;
        isRewinding = true;
        GetComponent<Rigidbody>().isKinematic = true;

    }


    public void StopRewind()
    {
        Time.timeScale = 1f;
        isRewinding = false;
        GetComponent<Rigidbody>().isKinematic = false;
        

    }
}
