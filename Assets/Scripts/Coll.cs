using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour
{
    
    public GameObject water_peg1;
    /*public GameObject water_peg2;*/
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "water_peg")
        {
            //print("Collided");

           // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }*/
    public float attractiveForce=0.1f;
    private void Update()
    {

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        float _x = water_peg1.transform.position.x;
        float _y = water_peg1.transform.position.y;
        float _z = water_peg1.transform.position.z;
       /* float x2 = water_peg2.transform.position.x;
        float y2 = water_peg2.transform.position.y;
        float z2 = water_peg2.transform.position.z;
*/
        if (y > 9.0f) 
        {

            if (_x < x)
            {
                gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
            }

            else if (_x > x)
            {
                gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
            }

        }

        
        /* if (_z < z)
         {
             gameObject.transform.position = new Vector3(x , y , (z - 0.001f));
         }
         else if (_z > z)
         {
             gameObject.transform.position = new Vector3(x, y , (z + 0.001f));
         }*/
    }
}
