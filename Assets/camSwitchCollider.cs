using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camSwitchCollider : MonoBehaviour
{

    public CinemachineVirtualCamera virtCam;
    public CinemachineFreeLook freeLookCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        virtCam.m_Priority = 11;
        freeLookCam.m_Priority = 10;

    }

    void OnTriggerExit(Collider collider)
    {
        virtCam.m_Priority = 10;
        freeLookCam.m_Priority = 11;

    }
}
