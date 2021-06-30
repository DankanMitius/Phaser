using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    float minFov = 25f;
 float maxFov = 60f;
 float sensitivity = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Camera following the character
    void Update()
    {
        int DistanceAway = 10;
        Vector3 PlayerPOS = GameObject.Find("Player").transform.transform.position;
        GameObject.Find("Main Camera").transform.position = new Vector3(PlayerPOS.x, PlayerPOS.y+2, PlayerPOS.z - DistanceAway);

        //zoom
        float fov  = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        Camera.main.fieldOfView = fov;
    }
}
