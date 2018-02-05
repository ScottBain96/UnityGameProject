using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{

    public GameObject thirdCam;
    public GameObject firstCam;
    public GameObject freeCam;
    public int camMode;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("v"))
        {
            thirdCam.SetActive(false);
            firstCam.SetActive(true);


        }
        else
        {
            thirdCam.SetActive(true);
            firstCam.SetActive(false);
        }

        if (Input.GetKey("z"))
        {
            thirdCam.SetActive(false);
            freeCam.SetActive(true);


        }


    }

    void OnTriggerEnter(Collider col)
    {
           if (col.tag == "Goal")
        {
            firstCam.SetActive(true);
            thirdCam.SetActive(false);
            Destroy(thirdCam);

        }

    }
}

//SWITCH CAMS BY CLICKING V
/*
 *  if (Input.GetKeyDown("v"))
        {
            if (camMode == 1)
            {
                camMode = 0;

            }
            else
            {
                camMode += 1;
            }

            if (camMode == 0)
            {
                thirdCam.SetActive(true);
                firstCam.SetActive(false);
            }

            if (camMode == 1)
            {
                thirdCam.SetActive(false);
                firstCam.SetActive(true);
            }

        }
 * 
 * 
 * 
 * 
 */