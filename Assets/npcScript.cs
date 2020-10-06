using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class npcScript : MonoBehaviour
{
    public Transform[] destinations;
    Transform destination;
    public NavMeshAgent agent;
    public GameObject Player;

    public float smallestDistance = 100;
    public Transform closestDest;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            foreach (Transform desti in destinations)
            {
                float distanceCheck = Vector3.Distance(Player.transform.position, desti.position);
                Debug.Log(distanceCheck);

                if (distanceCheck < smallestDistance)
                {
                    smallestDistance = distanceCheck;
                    closestDest = desti.transform;
                }

            }
        }

        agent.destination = closestDest.position;
        smallestDistance = 100;
    }
}
