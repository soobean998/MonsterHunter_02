using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class vCam : MonoBehaviour
{
    private GameObject camObj;

    CinemachineFreeLook freeLook;
    
    CinemachineComposer comp;
    
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        camObj = GameObject.FindWithTag("MainCamera");
        freeLook = camObj.GetComponent<CinemachineFreeLook> ();
        comp = freeLook.GetRig (1).GetCinemachineComponent<CinemachineComposer>();

        comp.m_TrackedObjectOffset.y = y;

        

    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Mouse Y");

     
        
    }
}
