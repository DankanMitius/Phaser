using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneRotation : MonoBehaviour
{
    public float rotationSpeed;
    Vector3 currentEulerAngles;
    float x;
    float y;
    float z;

    void Start()
    {
        
    }

  
    void Update()
    {
      
        float angle = 5;
    
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);

    }
}
