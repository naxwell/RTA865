using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerTrap : MonoBehaviour
{

    public Transform startingPosition;
    public GameObject playerPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red, Mathf.Infinity);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {

            hit.collider.GetComponent<health>().cubeHealth -= 1;
            float Health = hit.collider.GetComponent<health>().cubeHealth;
            // if (Health <= 0)
            // {
            //     Destroy(hit.collider.gameObject);
            //     Instantiate(playerPrefab, startingPosition.position, startingPosition.rotation);
            //     //hit.collider.transform.position = startingPosition.position;
            //     hit.collider.GetComponent<Animator>().SetBool("isDead", true);

            // }
        }

    }
}
