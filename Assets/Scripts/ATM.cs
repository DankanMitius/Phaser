using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM : MonoBehaviour
{
    public GameObject door;
 
    private void OnCollisionStay(Collision col)
    {

        if (col.gameObject.name == "Player" && Input.GetKeyDown("e"))
        {
            Destroy(door);

        }
    }
}
