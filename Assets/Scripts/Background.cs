using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    //   public Rigidbody rigidbodyComponent;
    // Start is called before the first frame update
    public float delta ;  // Amount to move left and right from the start point
    public float speed ;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        /*     int i = 1;
             if (i<10)
             {

                 rigidbodyComponent.velocity = new Vector3(10, 0, 0);
                 i++;
             }

          /*   for (int i = 1; i <= 10; i++)
             {

                 rigidbodyComponent.velocity = new Vector3(-10, 0, 0);
             }  */
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);

      if (Mathf.Sin(Time.time * speed)>0.999)  transform.rotation = Quaternion.Euler(0, -90, 0);

        if (Mathf.Sin(Time.time * speed) <-0.999) transform.rotation = Quaternion.Euler(0, 90, 0);

        transform.position = v;

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log(Mathf.Sin(Time.time * speed));
        }
    }
}
