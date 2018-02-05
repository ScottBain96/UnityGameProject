using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockFall : MonoBehaviour
{
    public GameObject myBlock;
    // Use this for initialization
    void Start()
    {

    }
    IEnumerator Timer()
    {

        yield return new WaitForSeconds(0.6f);

        Destroy(gameObject);

        myBlock.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {



    }




    //detect colision with trigger
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            StartCoroutine(Timer());

        }
    }
}