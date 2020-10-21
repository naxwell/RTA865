using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeButtons : MonoBehaviour
{

    public GameObject buttonPrefab;
    public Transform parentCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 positionToSpawn = new Vector3(Random.Range(0, 900), Random.Range(0, 400));
            GameObject newButt = Instantiate(buttonPrefab, positionToSpawn, transform.rotation);
            newButt.transform.parent = parentCanvas;
        }
    }
}
