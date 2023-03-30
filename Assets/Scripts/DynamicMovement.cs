using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class DynamicMovement : MonoBehaviour
{
    public GameObject linearSphere;

    private Vector3 linearPreviousPosition, linearCurrentPosition, linearVelocity;

    private Vector3 dynamicPosition, dynamicVelocity;

    
    public float f, zeta, r;
    private float constant1, constant2, constant3;

    void Start()
    {   
        constant1 = zeta / (Mathf.PI * f);
        constant2 = 1 / Mathf.Pow((2 * Mathf.PI * f), 2);
        constant3 = r * zeta / (2 * Mathf.PI * f);

        linearCurrentPosition = linearSphere.GetComponent<Transform>().position;
        dynamicPosition = linearSphere.GetComponent<Transform>().position;
        dynamicVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        linearPreviousPosition = linearCurrentPosition;
        linearCurrentPosition = linearSphere.GetComponent<Transform>().position;

        if (linearVelocity == Vector3.zero)
        { 
            linearVelocity = (linearCurrentPosition - linearPreviousPosition) / Time.deltaTime;
        }

        dynamicPosition += dynamicVelocity * Time.deltaTime;
        dynamicVelocity += Time.deltaTime * (linearCurrentPosition + constant3 * linearVelocity - dynamicPosition - constant1 * dynamicVelocity) / constant2;

        transform.position = dynamicPosition;
    }
}
