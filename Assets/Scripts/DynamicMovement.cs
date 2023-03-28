using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicMovement : MonoBehaviour
{
    LinearSphere linearSphere;

    private Vector3 linearVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        linearVelocity = (linearSphere.spherePosition - linearSphere.previousPosition) / Time.deltaTime;
    }
}
