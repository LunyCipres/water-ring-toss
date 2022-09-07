using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Buttons : MonoBehaviour
{

    public float Force = 
    2f;
    public float Dir = 0.5f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TouchButton();
    }

    private void FixedUpdate()
    {
        
    }

    void TouchButton()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 vector = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);

            //print(Input.mousePosition.y); //105 x-axis, 40 y-axis

            //print(vector);  < GetComponent<Rigidbody>().position.x < 400
            //print(GetComponent<Rigidbody>().position.x);
            print(vector.x);
            if(vector.x > 100)
            {
                //move left
                print("Im here");
                Vector3 impulse = new Vector3(-Dir, Force, 0.0f);
                if (GetComponent<Rigidbody>().position.x > -3)
                GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
            }
            else if(vector.x < 100)
            {
                
                //move right
                Vector3 impulse = new Vector3(Dir, Force, 0.0f);
                if (GetComponent<Rigidbody>().position.x < -3)
                GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
            }
        
        }
        
    }
}