using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Transform Tr;
    
    private float h;
    private float v;
    private float r;

    [Range(3.0f, 10.0f)]
    public float moveSpeed = 8.0f;
    [Range(30.0f, 150.0f)]
    public float turnSpeed = 200.0f;

    private Animator anim;

    private readonly int hashRunF = Animator.StringToHash("RunF");
    private readonly int hashRunB = Animator.StringToHash("RunB");
    private readonly int hashRunR = Animator.StringToHash("RunR");
    private readonly int hashRunL = Animator.StringToHash("RunL");
    private readonly int hashHit = Animator.StringToHash("Hit");

    public enum STATE {IDLE, RUNB, RUNF};

    private bool IsDie = false;

    // Start is called before the first frame update
    void Start()
    {
        Tr = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r = Input.GetAxis("Mouse X");

        
        
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        Tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);
        Tr.Rotate(Vector3.up * Time.deltaTime * turnSpeed * r );

        PlayerState();
    
    }

   

    void PlayerState()
    {
       
            if(v >= 0.1f)
            {
                anim.SetBool(hashRunF, true);
                anim.SetBool(hashRunB, false);
                  anim.SetBool(hashRunR, false);
                anim.SetBool(hashRunL, false);
            }
            else if(v <= -0.1f)
            {
                anim.SetBool(hashRunF, false);
                anim.SetBool(hashRunB, true);
                  anim.SetBool(hashRunR, false);
                anim.SetBool(hashRunL, false);
            }
            else if (h >= 0.1f)
            {
                  anim.SetBool(hashRunF, false);
                anim.SetBool(hashRunB, false);
                anim.SetBool(hashRunR, true);
                anim.SetBool(hashRunL, false);
            }
            else if (h <= -0.1f)
            {
                  anim.SetBool(hashRunF, false);
                anim.SetBool(hashRunB, false);
                anim.SetBool(hashRunR, false);
                anim.SetBool(hashRunL, true);
            }
            else
            {
                anim.SetBool(hashRunF, false);
                anim.SetBool(hashRunB, false);
                anim.SetBool(hashRunR, false);
                anim.SetBool(hashRunL, false);
            }

        
    }
}
