using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Buttons : MonoBehaviour
{

    public float Force = 
    1.5f;
    public float Dir = 1f; 
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

            //print(vector);  < GetComponent<Rigidbody>().position.x < 400
            print(GetComponent<Rigidbody>().position.x);
            if(vector.x > 400)
            {
                //move right
                Vector3 impulse = new Vector3(-Dir, Force, 0.0f);
                if (GetComponent<Rigidbody>().position.x > 1)
                GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
            }
            else if(vector.x < 400)
            {
                //move right
                Vector3 impulse = new Vector3(Dir, Force, 0.0f);
                if (GetComponent<Rigidbody>().position.x < 1)
                GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
            }
        
        }
        
    }
}