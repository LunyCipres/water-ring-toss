using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushHoop : MonoBehaviour
{
    

    public float Force = 
    2f;
    public float Dir = 0.5f; 

    public void moveLeft()
    {
        if (Time.timeScale != 0)
        {
            print("Im here");
            Vector3 impulse = new Vector3(-Dir, Force, 0.0f);
            if (GetComponent<Rigidbody>().position.x > -3)
            GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
        }
    }
    public void moveRight()
    {
        if (Time.timeScale != 0)
        {
            Vector3 impulse = new Vector3(Dir, Force, 0.0f);
            if (GetComponent<Rigidbody>().position.x < -3)
            GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
        }    
    }
}
