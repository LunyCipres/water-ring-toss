using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int  score=0;
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "water_peg")
        {
            print("Collided");

            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }*/
    //public GameObject water_peg;
    private void OnTriggerEnter(Collider collision1)
    {
        if (collision1.gameObject.tag == "score" )
        {
            score++;
            print("score=" + (score));

            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }
    
}
