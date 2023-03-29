using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicMovement : MonoBehaviour
{
    public GameObject linearSphere;

    private Vector3 linearPreviousPosition;
    private Vector3 linearCurrentPosition;
    private Vector3 linearVelocity;

    private float constant1, constant2, constant3;

    public DynamicMovement(float f, float zeta, float r)
    {
        linearCurrentPosition = linearSphere.GetComponent<Transform>().position;
        
        constant1 = zeta / (Mathf.PI * f);
        constant2 = 1 / Mathf.Pow((2 * Mathf.PI * f), 2);
        constant3 = r * zeta / (2 * Mathf.PI * f);
    }

    // Update is called once per frame
    void Update()
    {
        linearPreviousPosition = linearCurrentPosition;
        linearCurrentPosition = linearSphere.GetComponent<Transform>().position;

        linearVelocity = (linearCurrentPosition - linearPreviousPosition) / Time.deltaTime;
    }
}
