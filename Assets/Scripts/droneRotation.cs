using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneRotation : MonoBehaviour
{
    float rotationSpeed = 20;
    Vector3 currentEulerAngles;
    float x;
    float y;
    float z;
 //   public GameObject wing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.RotateAroundLocal(new Vector3(0,0,0), 20 * Time.deltaTime);
        // transform.Rotate(0, 20 * Time.deltaTime, 0);
        //   transform.localRotation.y = new Quaternion();
        // transform.Rotate(new Vector3(0, 20 * Time.deltaTime, 0), Space.Self);
        // transform.localRotation.SetEulerRotation(0, 20 * Time.deltaTime, 0);
        // Quaternion x = transform.localRotation;
        //    var rotationVector = transform.localRotation.eulerAngles;
        //    rotationVector.z = 15;

        //  transform.rotation = Quaternion.Euler(rotationVector);
        //  transform.localRotation = Quaternion.identity;
        //    transform.localEulerAngles =

        //  transform.rota
        //  if (Input.GetKeyDown(KeyCode.X)) x = 1 - x;
        //   if (Input.GetKeyDown(KeyCode.Y)) y = 1 - y;
        //  if (Input.GetKeyDown(KeyCode.Z)) z = 1 - z;
        //  y = 45;

        //modifying the Vector3, based on input multiplied by speed and time
        // currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;

        //apply the change to the gameObject
        //   transform.localEulerAngles = currentEulerAngles;
        // transform.localRotation = Quaternion.identity;
        //  x = transform.localRotation.x;
        // y = transform.localRotation.y;
        //  z = transform.localRotation.z;
        // y= Time.deltaTime * rotationSpeed;

        //najvaznije    transform.localRotation = Quaternion.Euler(0, y, 0);
        //   transform.eulerAngles =new Vector3(0, y, 0);
        float angle = 5;
      //  RectTransform rt = (RectTransform)wing.transform;
     //   float width = rt.rect.width;
       // float height = rt.rect.height;

        //  transform.rotation = Quaternion.identity;
        //  transform.RotateAround(transform.position + new Vector3(wing.GetWidth() / 2f, wing.GetHeight() / 2f, 0f), Vector3.forward, angle);
        //  transform.RotateAround(transform.position,Vector3.up,20 * Time.deltaTime);
       // transform.rotation = Quaternion.identity;
        //  transform.RotateAround( new Vector3(0,0,0), Vector3.up, angle);
     //   transform.Rotate(Vector3.up);
        transform.Rotate(Vector3.up, 20 * Time.deltaTime, Space.Self);

    }
}
