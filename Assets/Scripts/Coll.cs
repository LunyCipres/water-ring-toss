using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour
{

    public GameObject water_peg;
    public GameObject water_peg1;
    public GameObject water_peg2;
    public GameObject water_peg3;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "water_peg")
        {
            print("Collided");

            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }


    private void Update()
    {

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        float _x = water_peg.transform.position.x;
        float _y = water_peg.transform.position.y;
        float _z = water_peg.transform.position.z;

        float _x1 = water_peg1.transform.position.x;
        float _y1 = water_peg1.transform.position.y;
        float _z1 = water_peg1.transform.position.z;

        float _x2 = water_peg2.transform.position.x;
        float _y2 = water_peg2.transform.position.y;
        float _z2 = water_peg2.transform.position.z;

        float _x3 = water_peg3.transform.position.x;
        float _y3 = water_peg3.transform.position.y;
        float _z3 = water_peg3.transform.position.z;





        if (((((x * x) - (_x * _x)) * ((x * x) - (_x * _x))) < (((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1)))) && ((((x * x) - (_x * _x)) * ((x * x) - (_x * _x))) < (((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2)))) && ((((x * x) - (_x * _x)) * ((x * x) - (_x * _x))) < (((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3)))))
        {
            if (y > 10.0f)
            {
                if (_x < x)
                {
                    gameObject.transform.position = new Vector3((x - 0.1f), y, z);
                }

                else if (_x > x)
                {
                    gameObject.transform.position = new Vector3((x + 0.1f), y, z);
                }

            }
           

        }
        if (((((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))) < (((x * x) - (_x * _x)) * ((x * x) - (_x * _x)))) && ((((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))) < (((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2)))) && ((((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))) < (((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3)))))
        {
            if (y > 9.0f) 
            { 
                if (_x1 < x)
                {
                    gameObject.transform.position = new Vector3((x - 0.1f), y, z);
                }

                else if (_x1 > x)
                {
                    gameObject.transform.position = new Vector3((x + 0.1f), y, z);
                }
            }
        }
        if (((((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))) < (((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1)))) && ((((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))) < (((x * x) - (_x * _x)) * ((x * x) - (_x * _x)))) && ((((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))) < (((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3)))))
        {
            if(y> 11.1f)
            {
                if (_x2 < x)
                {
                    gameObject.transform.position = new Vector3((x - 0.1f), y, z);
                }

                else if (_x2 > x)
                {
                    gameObject.transform.position = new Vector3((x + 0.1f), y, z);
                }
            }
            
        }
        if (((((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))) < (((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1)))) && ((((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))) < (((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2)))) && ((((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))) < (((x * x) - (_x * _x)) * ((x * x) - (_x * _x)))))
        {
            if(y> 10.0f)
            {
                if (_x3 < x)
                {
                    gameObject.transform.position = new Vector3((x - 0.1f), y, z);
                }

                else if (_x3 > x)
                {
                    gameObject.transform.position = new Vector3((x + 0.1f), y, z);
                }
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
