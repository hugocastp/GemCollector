using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class VrLookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float angle;
    public float walkAngle = 25.0f;
    public float walkBack = 330.0f;
    public float speed = 7.0f;
    public float backSpeed = -3.0f;
    public bool moveForward;
    public bool moveBackwards;

    public CharacterController cc;

    void Start()
    {
        cc = GetComponentInParent<CharacterController>();
    }

    void Update()
    {
        angle = vrCamera.eulerAngles.x;
        if (vrCamera.eulerAngles.x >= walkAngle && vrCamera.eulerAngles.x < 75.0f)
        {
            moveForward = true;
        }

        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed*2);
        }

        if (vrCamera.eulerAngles.x <= walkBack && vrCamera.eulerAngles.x > 280.0f)
        {
            moveBackwards = true;
        }

        else
        {
            moveBackwards = false;
        }

        if (moveBackwards)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * (backSpeed)*2);
        }
    }
}
