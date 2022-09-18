using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour
{

    public GameObject water_peg;
    public GameObject water_peg1;
    public GameObject water_peg2;
    public GameObject water_peg3;
    public float attractiveForce = 0.1f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "water_peg")
        {
            print("Collided");

            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }
    

    private void FixedUpdate()
    {

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        float _x = 0, _x1 = 0, _x2 = 0, _x3 = 0;

        //statement 1, 2, 3, 4
        /*
            if 1 is min

        */
        float minDist = 1000;
        int minID = -1;


        // peg 0
        if (water_peg != null) {
            _x = water_peg.transform.position.x;

            if (Mathf.Pow((x * x) - (_x * _x), 2) < minDist) {
                minDist = Mathf.Pow((x * x) - (_x * _x), 2);
                minID = 0;
            }
        }
        // peg 1
        if (water_peg1 != null) {
            _x1 = water_peg1.transform.position.x;

            if (Mathf.Pow((x * x) - (_x1 * _x1), 2) < minDist) {
                minDist = Mathf.Pow((x * x) - (_x1 * _x1), 2);
                minID = 1;
            }
        }
        // peg2
        if (water_peg2 != null) {
            _x2 = water_peg2.transform.position.x;

            if (Mathf.Pow((x * x) - (_x2 * _x2), 2) < minDist) {
                minDist = Mathf.Pow((x * x) - (_x2 * _x2), 2);
                minID = 2;
            }
        }
        // peg 3
        if (water_peg3 != null) {
            _x3 = water_peg3.transform.position.x;

            if (Mathf.Pow((x * x) - (_x3 * _x3), 2) < minDist) {
                minDist = Mathf.Pow((x * x) - (_x3 * _x3), 2);
                minID = 3;
            }
        }

        // print("min dist: " + minDist + "\t peg: " + minID);

        switch (minID)
        {
            case 0:
                if (y > 10.0f)
                {
                    // print("going to peg 0");
                    if (_x < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
                    }

                }
                break;
            case 1:
                 if (y > 9.0f) 
                { 
                    // print("going to peg 1");
                    if (_x1 < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x1 > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
                    }
                }
                break;
            case 2:
                if(y> 11.1f)
                {
                    // print("going to peg 2");
                    if (_x2 < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x2 > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
                    }
                }
                break;
            case 3:
                if(y> 10.0f)
                {
                    // print("going to peg 3");
                    if (_x3 < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x3 > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
                    }
                }
                break;
        }

    }
}


        // if (
        //     // ((((x * x) - (_x * _x)) * ((x * x) - (_x * _x))) < (((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))))
        //     // && ((((x * x) - (_x * _x)) * ((x * x) - (_x * _x))) < (((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))))
        //     // && ((((x * x) - (_x * _x)) * ((x * x) - (_x * _x))) < (((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))))
        //     (Mathf.Pow((x * x) - (_x * _x), 2) < Mathf.Pow((x * x) - (_x1 * _x1), 2))
        //     && (Mathf.Pow((x * x) - (_x * _x), 2) < Mathf.Pow((x * x) - (_x2 * _x2), 2))
        //     && (Mathf.Pow((x * x) - (_x * _x), 2) < Mathf.Pow((x * x) - (_x3 * _x3), 2))
        // )
        // {
        //     if (y > 10.0f)
        //     {
        //         if (_x < x)
        //         {
        //             gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
        //         }

        //         else if (_x > x)
        //         {
        //             gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
        //         }

        //     }
           

        // }
        // if (
        //     ((((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))) < (((x * x) - (_x * _x)) * ((x * x) - (_x * _x))))
        //     && ((((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))) < (((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))))
        //     && ((((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))) < (((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))))
        // )
        // {
        //     if (y > 9.0f) 
        //     { 
        //         if (_x1 < x)
        //         {
        //             gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
        //         }

        //         else if (_x1 > x)
        //         {
        //             gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
        //         }
        //     }
        // }
        // if (
        //     ((((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))) < (((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))))
        //     && ((((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))) < (((x * x) - (_x * _x)) * ((x * x) - (_x * _x))))
        //     && ((((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))) < (((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))))
        // )
        // {
        //     if(y> 11.1f)
        //     {
        //         if (_x2 < x)
        //         {
        //             gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
        //         }

        //         else if (_x2 > x)
        //         {
        //             gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
        //         }
        //     }
            
        // }
        // if (
        //     ((((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))) < (((x * x) - (_x1 * _x1)) * ((x * x) - (_x1 * _x1))))
        //     && ((((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))) < (((x * x) - (_x2 * _x2)) * ((x * x) - (_x2 * _x2))))
        //     && ((((x * x) - (_x3 * _x3)) * ((x * x) - (_x3 * _x3))) < (((x * x) - (_x * _x)) * ((x * x) - (_x * _x))))
        // )
        // {
        //     if(y> 10.0f)
        //     {
        //         if (_x3 < x)
        //         {
        //             gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
        //         }

        //         else if (_x3 > x)
        //         {
        //             gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
        //         }
        //     }
            
        // }
        /* if (_z < z)
         {
             gameObject.transform.position = new Vector3(x , y , (z - 0.001f));
         }
         else if (_z > z)
         {
             gameObject.transform.position = new Vector3(x, y , (z + 0.001f));
         }*/