using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;
    private bool moving;
    private void OnCollisionEnter(Collision collision)
    {
     //   if (collision.collider.name == "Player")
       // {
            moving = true;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
