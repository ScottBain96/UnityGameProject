using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButton : MonoBehaviour {
    public GameObject GameObject;
   // private Vector3 startPos;


    /*
    //Single hit trigger (doesn't require holding the button down)
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
    */
    //Trigger will stay open if there is a collision
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "KeyBox")
        {
         
                GameObject.GetComponent<Animator>().enabled = true;
            
           


            //Move wall
            //GameObject.transform.position += GameObject.transform.forward * Time.deltaTime;

        }
    
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "KeyBox")
        {
            GameObject.GetComponent<Animator>().enabled = false;

        }
    }


}
