using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGems : MonoBehaviour
{
    public Transform Gem;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);

        // Gem.position += Vector3.up * 4.0f * Time.deltaTime;

    }
}
