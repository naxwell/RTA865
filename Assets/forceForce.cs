using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceForce : MonoBehaviour
{
    Rigidbody _rb;
    public float amount = 100;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward * amount);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
