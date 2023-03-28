using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearSphere : MonoBehaviour
{
    public Vector3 spherePosition;
    public Vector3 previousPosition; 

    // Start is called before the first frame update
    void Start()
    {
        spherePosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        previousPosition = spherePosition;
        spherePosition = GetComponent<Transform>().position;
    }
}
