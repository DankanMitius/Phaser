using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileX : MonoBehaviour
{
    private Camera theCam;
    public float speed=10f;
    public Transform firePoint;
    public GameObject bulletToFire;
   // bool exist = false;
    public GameObject hand;
    public GameObject player;
    GameObject bullet1;
    // Start is called before the first frame update
    void Start()
    {
        theCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {


        //follow the player
        var pos = transform.position;
        var pos1 = hand.transform.position;
     //   transform.position = hand.transform.position;
        pos.x = pos1.x;
        pos.y = pos1.y;
        pos.z = 0;
        transform.position =new Vector3(pos.x,pos.y,pos.z);
      

 

    //aim angle
    Vector3 mousePos = Input.mousePosition;
        Vector3 screenpoint = theCam.WorldToScreenPoint(transform.localPosition);
        Vector2 offset = new Vector2(mousePos.x - screenpoint.x,mousePos.y - screenpoint.y);
        float angle = Mathf.Atan2(offset.y,offset.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f,angle);


        if (Input.GetKeyDown("v") && Input.GetKey(KeyCode.Mouse0) && bullet1 ==null)
        {
           bullet1 =  Instantiate(bulletToFire, firePoint.position, transform.rotation) as GameObject;
         
            Destroy(bullet1, 4);
         //   if (bullet1 == null) exist = false;
            bullet1.GetComponent<Rigidbody>().velocity= transform.right* speed;

        }
        if (bullet1 != null)
        {
            if (Input.GetKeyDown("b"))
            {
                player.transform.position = bullet1.transform.position;
                Destroy(bullet1);
            }
        }

        //test
        if (Input.GetKeyDown(KeyCode.Y))
        {
         

          //    Debug.Log(bullet1);
        }
    }
}
