using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class switchCam : MonoBehaviour
{

    public CinemachineFreeLook cam1;
    public CinemachineVirtualCamera cam2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {

            if (cam1.m_Priority == 10)
            {
                cam1.m_Priority = 11;
                cam2.m_Priority = 10;
            }
            else
            {
                cam1.m_Priority = 10;
                cam2.m_Priority = 11;
            }
        }
    }
}
