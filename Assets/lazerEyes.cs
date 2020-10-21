using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerEyes : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        Vector3 fwd = transform.forward;


        if (Input.GetKeyDown(KeyCode.E))
        {

            RaycastHit hit;
            if (Physics.Raycast(transform.position, fwd, out hit, Mathf.Infinity))
            {
                print("There is something in front of the object!");
                //Destroy(hit.collider.gameObject);
                hit.collider.GetComponent<health>().cubeHealth -= 1;
                float cubeHealth = hit.collider.GetComponent<health>().cubeHealth;
                if (cubeHealth <= 0)
                {
                    Destroy(hit.collider.gameObject);
                }
            }

        }
    }
}
