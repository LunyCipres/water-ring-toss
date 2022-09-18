using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushHoop : MonoBehaviour
{
    
    public GameObject water_peg1;
    public GameObject water_peg2;
    public GameObject water_peg3;
    public GameObject water_peg4;

    
    [SerializeField]
    private double threshold = 0.2;
    [SerializeField]
    private float reduceForceFactor = 10;

    public float Force = 
    2f;
    public float Dir = 0.5f; 

    private int isInPeg() {

        float x = transform.position.x;
        float y = transform.position.y;
        // float z = transform.position.z;

        //peg1
        if (water_peg1 != null)
        {
            float _x1 = water_peg1.transform.position.x;
            float _y1 = water_peg1.transform.position.y;
            
            if ( (Mathf.Abs(x - _x1) < threshold) && (Mathf.Abs(x - _x1) < threshold))
            {
                return 1;
            }
        }

        //peg2
        if (water_peg2 != null)
        {
            float _x2 = water_peg2.transform.position.x;
            float _y2 = water_peg2.transform.position.y;
            
            if ( (Mathf.Abs(x - _x2) < threshold) && (Mathf.Abs(x - _x2) < threshold))
            {
                return 1;
            }
        }

        //peg3
        if (water_peg3 != null)
        {
            float _x3 = water_peg3.transform.position.x;
            float _y3 = water_peg3.transform.position.y;
            
            if ( (Mathf.Abs(x - _x3) < threshold) && (Mathf.Abs(x - _x3) < threshold))
            {
                return 1;
            }
        }

        //peg4
        if (water_peg4 != null)
        {
            float _x4 = water_peg4.transform.position.x;
            float _y4 = water_peg4.transform.position.y;
            
            if ( (Mathf.Abs(x - _x4) < threshold) && (Mathf.Abs(x - _x4) < threshold))
            {
                return 1;
            }
        }

        return 0;
    }

    public void moveLeft()
    {
        if (Time.timeScale != 0)
        {
            print("Im here");
            Vector3 impulse;

            if (isInPeg() == 1)
            {
                print("reduced");
                impulse = new Vector3(-Dir, Force/reduceForceFactor, 0.0f);
            }
            else
            {
                impulse = new Vector3(-Dir, Force, 0.0f);
            }
            if (GetComponent<Rigidbody>().position.x > -3)
            GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
        }
    }
    public void moveRight()
    {
        if (Time.timeScale != 0)
        {
            Vector3 impulse;
            if (isInPeg() == 1)
            {
                print("reduced");
                impulse = new Vector3(Dir, Force/reduceForceFactor, 0.0f);
            }
            else
            {
                impulse = new Vector3(Dir, Force, 0.0f);
            }
            if (GetComponent<Rigidbody>().position.x < -3)
            GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
        }    
    }
}
