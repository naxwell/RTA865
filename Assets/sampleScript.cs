using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // Renderer mat = other.gameObject.GetComponent<Renderer>();

        // if (other.gameObject.CompareTag("destroy"))
        // {
        //     //Destroy(other.gameObject);
        //     mat.material.color = Color.red;
        // }
        other.gameObject.GetComponent<health>().cubeHealth += 1;

    }

    void OnCollisionEnter(Collision other)
    {

        // Renderer mat = other.gameObject.GetComponent<Renderer>();

        // if (other.gameObject.CompareTag("destroy"))
        // {
        //     //Destroy(other.gameObject);
        //     mat.material.color = Color.red;
        // }
    }
}
