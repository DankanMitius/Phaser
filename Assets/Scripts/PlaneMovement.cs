using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public GameObject unit;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {


    }
    private void OnCollisionEnter(Collision collision)
    {
        //   if (collision.collider.name == "Player")
        // {
        collision.collider.transform.SetParent(transform);
        //  Debug.Log(collision.gameObject.tag == "Player");
        //  }
    }
    private void OnCollisionExit(Collision collision)
    {
        //   if (collision.gameObject.CompareTag("Player"))
        // {
        //  moving = true;
        collision.collider.transform.SetParent(null);
        //  }
    }
    // Update is called once per frame
    void Update()
    {

        float y = Mathf.PingPong(Time.time * speed, 3) * 6+35;
        float x = transform.position.x;
        unit.transform.position = new Vector3(x, y, 0);

    }

    //material 24/25/23/22
}
