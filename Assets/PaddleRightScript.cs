using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRightScript : MonoBehaviour
{
    HingeJoint hinge;
    JointSpring hingeSpring;
    public string inputKeyName = "RightPaddle";

    // Use this for initialization
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {

        hingeSpring = hinge.spring;
        hingeSpring.spring = 200000f;
        hingeSpring.damper = 0;

        if (Input.GetAxis(inputKeyName) == 1) {
            hingeSpring.targetPosition = 45;
        } else {
            hingeSpring.targetPosition = 0;
        }

        hinge.spring = hingeSpring;
        
    }

}
