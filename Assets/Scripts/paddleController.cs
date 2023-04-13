using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    [SerializeField] KeyCode input;
    [SerializeField] float springPower;
    HingeJoint hinge;
    float targetPressed;
    float targetReleassed;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetReleassed = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        readInput();
    }

    void readInput(){
        JointSpring jointSpring = hinge.spring;
        if(Input.GetKey(input)){
            jointSpring.targetPosition = targetPressed;
        }
        else{
            jointSpring.targetPosition = targetReleassed;
        }
        hinge.spring = jointSpring;
    }
}
