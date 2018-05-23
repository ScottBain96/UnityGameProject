using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour {

    public static int levelN = 0;
    public static int Falling = 0;
    private Vector3 startPos;
  
    private Vector3 startPostCube;
    private Quaternion startRot;
    public bool hello = false;
   // public GameObject enableCheckText;






    // Use this for initialization
    void Start () {
       // enableCheckText.SetActive(false);
        startPos = transform.position;
        startRot = transform.rotation;
        startPostCube = transform.position;
        


    }

    void nextLevel()
    {
        levelN++;
        if(levelN > 1)
        {
            levelN = 0;

        }
        //Application.LoadLevel(levelN);
        SceneManager.LoadScene(levelN);

    }



    //detect colision with trigger
    void OnTriggerEnter(Collider col)
    {

       if (col.tag == "Fall")
        {
            Falling = 1;
        }

       if (col.tag == "NotFall")
        {

            Falling = 0;
        }


        else  if (col.tag == "Death" && Falling == 0) 
        {
            transform.position = startPos;
            transform.rotation = startRot;
            GetComponent<Animator>().Play("LOSE00", -1, 0f);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
           


        }

        else if (col.tag == "Death" && Falling == 1)
        {
            transform.position = startPos;
            transform.rotation = startRot;
            GetComponent<Animator>().Play("LOSE00", -1, 0f);
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
            SceneManager.LoadScene("level2");
            GetComponent<Animator>().Play("LOSE00", -1, 0f);



        }






        else if (col.tag == "CheckPoint")
        {
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
            //GetComponent<Animator>().Play("REFLESH00", -1, 0f);
            GetComponent<Animator>().Play("POSE31", -1, 0f);
            
            //enableCheckText.SetActive(true);

            // enableCheckText.SetActive(false);

        }
        else if (col.tag == "Goal")
        {
            Destroy(col.gameObject);
        
            GetComponent<Animator>().Play("WIN00", -1, 0f);

            Invoke("nextLevel", 3f);

        }

    
      
      
    }

}
