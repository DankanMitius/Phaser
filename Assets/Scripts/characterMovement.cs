using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    [SerializeField] public Transform groundCheckTransform;
    [SerializeField] public LayerMask playermask;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;

    //test for movement
   
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();

    }

    void Update()
    {
     
        //jump script
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;

        }


        horizontalInput = Input.GetAxis("Horizontal");

        //test
        if (Input.GetKeyDown(KeyCode.Y))
        {

            Debug.Log("Overlap= " + Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length);
            
        }   

        

    }

    private void FixedUpdate()
    {

        bool forwardPressed = Input.GetKey("d");
        bool backPressed = Input.GetKey("a");
        bool movePressed = forwardPressed || backPressed;
        bool runPressed = Input.GetKey("left shift");
        rigidbodyComponent.velocity = new Vector3(horizontalInput * 1.5f, rigidbodyComponent.velocity.y, 0);


        if (movePressed && runPressed)
        {
            rigidbodyComponent.velocity = new Vector3(horizontalInput * 3, rigidbodyComponent.velocity.y, 0);
        }

        //jumping and double jump check
       /*    if (jumpKeyWasPressed && (Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length != 1))
           {

               rigidbodyComponent.AddForce(Vector3.up * 8, ForceMode.VelocityChange);
               jumpKeyWasPressed = false;
           }  */
       if (Physics.OverlapSphere(groundCheckTransform.position,0.1f,playermask).Length==0)
        {
            return;
        }
      if (jumpKeyWasPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * 8, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }
  
}
