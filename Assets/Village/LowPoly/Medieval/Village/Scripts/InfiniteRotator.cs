using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRotator : MonoBehaviour
{
    public Transform transformToRotate;
    [Range(1f,100f)]
    public float RotationSpeed = 0.1f;
    public bool RotateOnStart = true;
    private bool isRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        if (RotateOnStart)
        {
            Debug.Log("Rotate on Start");
            StartRotating();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            float angle = RotationSpeed * Time.deltaTime;
            transformToRotate.Rotate(0f, 0f, angle);
        }
    }

    public void StartRotating()
    {
        isRotating = true;
    }

    public void StopRotating()
    {
        isRotating = false;
    }


}
