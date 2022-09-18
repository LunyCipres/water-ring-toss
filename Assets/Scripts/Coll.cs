using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MyApplication
{

    public class Coll : MonoBehaviour
    {

        public GameObject water_peg1;
        public GameObject water_peg2;
        public GameObject water_peg3;
        public GameObject water_peg4;
        /*public GameObject water_peg2;*/
        /*private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "water_peg")
            {
                //print("Collided");

               // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
            }

        }*/

        public float attractiveForce = 1.0f;
        
        private void fixedUpdate()
        {

            float x = transform.position.x;
            float y = transform.position.y;
            float z = transform.position.z;
            float _x1 = water_peg1.transform.position.x;
            float _y1 = water_peg1.transform.position.y;
            float _z1 = water_peg1.transform.position.z;

            float _x2 = water_peg1.transform.position.x;
            float _y2 = water_peg1.transform.position.y;
            float _z2 = water_peg1.transform.position.z;

            float _x3 = water_peg1.transform.position.x;
            float _y3 = water_peg1.transform.position.y;
            float _z3 = water_peg1.transform.position.z;

            float _x4 = water_peg1.transform.position.x;
            float _y4 = water_peg1.transform.position.y;
            float _z4 = water_peg1.transform.position.z;
            /* float x2 = water_peg2.transform.position.x;
             float y2 = water_peg2.transform.position.y;
             float z2 = water_peg2.transform.position.z;
     */
            if (Math.Abs(_y1-y) < Math.Abs(_y2 - y) && Math.Abs(_y1 - y)< Math.Abs(_y3 - y) && Math.Abs(_y1 - y) < Math.Abs(_y4 - y))
            { 
                if (y > 6.0f)
                {

                    if (_x1 < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x1 > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
                    }

                }
            }
            if (Math.Abs(_y2 - y) < Math.Abs(_y1 - y) && Math.Abs(_y2 - y) < Math.Abs(_y3 - y) && Math.Abs(_y2 - y) < Math.Abs(_y4 - y))
            {
                if (y > 6.0f)
                {

                    if (_x2 < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x2 > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
                    }

                }
            }
            if (Math.Abs(_y3 - y) < Math.Abs(_y1 - y) && Math.Abs(_y3 - y) < Math.Abs(_y2 - y) && Math.Abs(_y3 - y) < Math.Abs(_y4 - y))
            {
                if (y > 6.0f)
                {

                    if (_x3 < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x3 > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
                    }

                }
            }
            if (Math.Abs(_y4 - y) < Math.Abs(_y1 - y) && Math.Abs(_y4 - y) < Math.Abs(_y2 - y) && Math.Abs(_y4 - y) < Math.Abs(_y3 - y))
            {
                if (y > 6.0f)
                {

                    if (_x4 < x)
                    {
                        gameObject.transform.position = new Vector3((x - attractiveForce), y, z);
                    }

                    else if (_x4 > x)
                    {
                        gameObject.transform.position = new Vector3((x + attractiveForce), y, z);
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
}